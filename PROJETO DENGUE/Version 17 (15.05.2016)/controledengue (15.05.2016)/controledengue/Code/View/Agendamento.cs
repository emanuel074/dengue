using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controledengue.Code.BLL;
using controledengue.Code.DTO;

namespace controledengue.Code.View
{
    public partial class Agendamento : Form
    {
        AgendamentoBLL bll = new AgendamentoBLL();
        AgendamentoDTO dto = new AgendamentoDTO();


        public Agendamento()
        {
            InitializeComponent();
        }

        private void Agendamento_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch
            {
                MessageBox.Show("Falha ao conectar com o servidor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtBairro.Text != "" && txtNome.Text != "" && cmbGrupo.Text != "" && cmbPeriodo.Text != "" && mktDataMarcada.Text != "")
            {
                dto.Codigo = txtCodigo.Text;
                dto.Nome = txtNome.Text;
                dto.Bairro = txtBairro.Text;
                dto.Data_Visita = mktDataMarcada.Text;
                dto.Periodo = cmbPeriodo.Text;
                dto.Grupo = cmbGrupo.Text;

                bll.Inserir(dto);
                MessageBox.Show("Agendamento efetuado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();
                LimparTela();
            }
            else
            {
                MessageBox.Show("Para concluir o Agendamento, preencha todos os campos.",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtBairro.Text != "" && txtNome.Text != "" && cmbGrupo.Text != "" && cmbPeriodo.Text != "" && mktDataMarcada.Text != "")
            {

                dto.Nome = txtNome.Text;
                dto.Bairro = txtBairro.Text;
                dto.Data_Visita = mktDataMarcada.Text;
                dto.Periodo = cmbPeriodo.Text;
                dto.Grupo = cmbGrupo.Text;
                dto.Codigo = txtCodigo.Text;

                bll.Atualizar(dto);
                MessageBox.Show("Agendamento atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTela();
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Ops! Há campos vazios.",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                var result = MessageBox.Show("Deseja realmente excluir o registro selecionado?", "Exclusão Agente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    bll.Excluir(txtCodigo.Text);
                    MessageBox.Show("O agente foi excluido com sucesso", "Exclusão com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                    LimparTela();

                }
                else
                {
                    MessageBox.Show("Selecione o agendamento para apagar!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            cmbPeriodo.Text = "";
            cmbGrupo.Text = "";
        }

        public void LimparTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            cmbPeriodo.Text = "";
            cmbGrupo.Text = "";
        }

        private void gridagente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = gridagente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = gridagente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBairro.Text = gridagente.Rows[e.RowIndex].Cells[2].Value.ToString();
            mktDataMarcada.Text = gridagente.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbPeriodo.Text = gridagente.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbGrupo.Text = gridagente.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar ao menu principal ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MenuInicial controle = new MenuInicial();
                controle.Show();
                this.Hide();
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (mtbPesquisar.Text != "")
            {
                gridagente.DataSource = bll.pesquisarAgentePorNome(mtbPesquisar.Text);
            }
            else
            {
                MessageBox.Show("Você esqueceu de preencher o campo de Nome.", "Atenção!!!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }          
        }

        private void btAtualizaGrid_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            mtbPesquisar.Text = "";
        }
        public void CarregarGrid()
        {
            gridagente.DataSource = bll.SelecionartodosAgentes();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloquia letras
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia nº
            if ((Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia nº
            if ((Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void mtbPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia nº
            if ((Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void cmbPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       
    }
}
