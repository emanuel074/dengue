using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetoAgendamento.Code.BLL;
using projetoAgendamento.Code.DTO;


namespace projetoAgendamento
{
    public partial class Form1 : Form
    {
        Agente_BLL bll = new Agente_BLL();
        Agente_DTO dto = new Agente_DTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                CarregarGrid();
            }
            catch
            {
                MessageBox.Show("Erro Aguarde!");
            }
        }

        public void CarregarGrid()
        {
            gridagente.DataSource = bll.SelecionartodosAgentes();
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
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }


        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            mktDataMarcada.Clear();
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

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            dto.Codigo = txtCodigo.Text;
            dto.Nome = txtNome.Text;
            dto.Bairro = txtBairro.Text;
            dto.Data_Visita = mktDataMarcada.Text;
            dto.Periodo = cmbPeriodo.Text;
            dto.Grupo = cmbGrupo.Text;

            bll.Atualizar(dto);
            MessageBox.Show("Agendamento atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarGrid();
        }


        private void btExcluir_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                var result = MessageBox.Show("Deseja realmente excluir o registro selecionado?", "Exclusão Agente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    bll.Excluir(txtCodigo.Text);
                    MessageBox.Show("O agente foi excluido com sucesso", "Exclusão com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btAtualizar_Click_1(object sender, EventArgs e)
        {
            dto.Codigo = txtCodigo.Text;
            dto.Nome = txtNome.Text;
            dto.Bairro = txtBairro.Text;
            dto.Data_Visita = mktDataMarcada.Text;
            dto.Periodo = cmbPeriodo.Text;
            dto.Grupo = cmbGrupo.Text;

            bll.Atualizar(dto);
            MessageBox.Show("Agendamento atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarGrid();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

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
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia nº
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
    }
}
