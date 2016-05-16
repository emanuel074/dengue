using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controledengue.Code.DTO;
using controledengue.Code.BLL;
using controledengue.Code.View;

namespace controledengue
{
    public partial class ControleAgente : Form
    {
        public ControleAgente()
        {
            InitializeComponent();
        }

        ControleBLL bll = new ControleBLL();
        ControleDTO dto = new ControleDTO();

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar ao menu principal ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MenuInicial controle = new MenuInicial();
                controle.Show();
                this.Hide();
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar ao menu principal ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MenuInicial controle = new MenuInicial();
                controle.Show();
                this.Hide();
            }
        }

        private void btInserir(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtIdade.Text != "" && mkdCpf.Text != "" && txtRg.Text != "" && mkdDataNasc.Text != "" && txtEmail.Text != "" && cbSexo.Text != "" && cbEstadoCivil.Text != "" && txtEndereco.Text != "" && txtBairro.Text != "" && txtNumero.Text != "" && cbMunicipio.Text != "" && cbEstado.Text != "" && mkdTelefone.Text != "" && mkdCelular.Text != "")
            {
                dto.NomeProfissional = txtNome.Text;
                dto.Idade = int.Parse(txtIdade.Text);
                dto.Cpf = mkdCpf.Text;
                dto.N_identidade = txtRg.Text;
                dto.DataNascimentoProfissional1 = mkdDataNasc.Text;
                dto.Email = txtEmail.Text;
                dto.Sexo = cbSexo.Text;
                dto.EstadoCivil = cbEstadoCivil.Text;
                dto.EndereçoProfissional = txtEndereco.Text;
                dto.Bairro = txtBairro.Text;
                dto.NumFilial = int.Parse(txtNumero.Text);
                dto.Municipio = cbMunicipio.Text;
                dto.Estado = cbEstado.Text;
                dto.Telefone = mkdTelefone.Text;
                dto.Celular = mkdCelular.Text;

                bll.Inserir(dto);
                MessageBox.Show("O Agente foi cadastrado com sucesso!", "Salvo com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparTela();
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Para concluir o Cadastro do Agente, preencha todos os campos.",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            }   
        }
        
        private void dataGridViewAgentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCod.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIdade.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[2].Value.ToString();
            mkdCpf.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRg.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[4].Value.ToString();
            mkdDataNasc.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbSexo.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbEstadoCivil.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtEndereco.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtBairro.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtNumero.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[11].Value.ToString();
            cbMunicipio.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[12].Value.ToString();
            cbEstado.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[13].Value.ToString();
            mkdTelefone.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[14].Value.ToString();
            mkdCelular.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[15].Value.ToString();

        }

        public void CarregarGrid()
        {
            dataGridViewAgentes.DataSource = bll.Selecionar();
        }

        public void LimparTela()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtIdade.Clear();
            mkdCpf.Clear();
            txtRg.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            mkdTelefone.Clear();
            mkdCelular.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            cbSexo.Text = "";
            cbEstadoCivil.Text = "";
            cbEstado.Text = "";
            cbMunicipio.Text = "";
            cbEstado.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void tpControle_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtNome.Clear();
            txtIdade.Clear();
            mkdCpf.Clear();
            txtRg.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            mkdTelefone.Clear();
            mkdCelular.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            cbSexo.Text = "";
            cbEstadoCivil.Text = "";
            cbEstado.Text = "";
            cbMunicipio.Text = "";
            cbEstado.Text = "";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                var result = MessageBox.Show("Deseja realmente excluir ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);              

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    bll.Excluir(txtCod.Text);

                    MessageBox.Show("O Agente foi excluído com sucesso!", "Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTela();
                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show("Selecione o agente para apagar!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtIdade.Text != "" && mkdCpf.Text != "" && txtRg.Text != "" && mkdDataNasc.Text != "" && txtEmail.Text != "" && cbSexo.Text != "" && cbEstadoCivil.Text != "" && txtEndereco.Text != "" && txtBairro.Text != "" && txtNumero.Text != "" && cbMunicipio.Text != "" && cbEstado.Text != "" && mkdTelefone.Text != "" && mkdCelular.Text != "")
            {

                dto.NomeProfissional = txtNome.Text;
                dto.Idade = int.Parse(txtIdade.Text);
                dto.Cpf = mkdCpf.Text;
                dto.N_identidade = txtRg.Text;
                dto.DataNascimentoProfissional1 = mkdDataNasc.Text;
                dto.Email = txtEmail.Text;
                dto.Sexo = cbSexo.Text;
                dto.EstadoCivil = cbEstadoCivil.Text;
                dto.EndereçoProfissional = txtEndereco.Text;
                dto.Bairro = txtBairro.Text;
                dto.NumFilial = int.Parse(txtNumero.Text);
                dto.Municipio = cbMunicipio.Text;
                dto.Estado = cbEstado.Text;
                dto.Telefone = mkdTelefone.Text;
                dto.Celular = mkdCelular.Text;
                dto.CodigoAgente = int.Parse(txtCod.Text);

                bll.Atualizar(dto);
                MessageBox.Show("Agente atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTela();
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Nenhum agente selecionado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btAtualiza_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            mtbPesquisar.Text = "";
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloquia letras
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia nº
            if ((Char.IsNumber(e.KeyChar)) )
                e.Handled = true;
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloquia letras
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
        if ( (Char.IsWhiteSpace(e.KeyChar)) )
                e.Handled = true;
        }

        private void confimaEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloquia letras
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (mtbPesquisar.Text != "")
            {

            dataGridViewAgentes.DataSource = bll.pesquisarAgentePorNome(mtbPesquisar.Text);

            }

            else
            {
                MessageBox.Show("Você esqueceu de preencher o campo de Nome.", "Erro!!!",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia nº e espaço
            if ((Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void mtbPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia nº
            if ((Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void cbEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

      


       
    }
}