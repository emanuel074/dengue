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
//using controledenguee.Relatorios;

namespace controledengue.Code.View
{
    public partial class CadastrarUnidade : Form
    {

        UnidadeBLL bll = new UnidadeBLL();
        UnidadeDTO dto = new UnidadeDTO();

        public CadastrarUnidade()
        {
            InitializeComponent();
        }

        private void CadastrarUnidade_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dto.Cnpj = txtCnpj.Text;
            dto.Nome = txtNome.Text;
            dto.CodUf = txtCodigoUf.Text;
            dto.Endereco = txtEndereco.Text;
            dto.Bairro = txtBairro.Text;
            dto.NumFilial = Int32.Parse(txtNumero.Text);
            dto.Cep = txtCep.Text;
            dto.Uf = cbUf.Text;
            dto.Municipio = cbMunici.Text;
            dto.Telefone = txtTel.Text;
            dto.Email = txtEmail.Text;

            if (txtId.Text == "")
            {
                bll.inserir(dto);

                MessageBox.Show("A unidade foi cadastrado com sucesso!", "Inserido com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dto.Id = int.Parse(txtId.Text);
                bll.Atualizar(dto);
                MessageBox.Show("A unidade foi atualizada com sucesso!", "Atualizado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpaTela();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            gridUnidade.DataSource = bll.SelecionaTodasUnidades();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar ao menu principal ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                menu controle = new menu();
                controle.Show();
                this.Hide();    
            }
        }

        private void LimpaTela()
        {
            txtCnpj.Clear();
            txtNome.Clear();
            txtCodigoUf.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtTel.Clear();
            txtId.Clear();
            txtEmail.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                var result = MessageBox.Show("Deseja realmente excluir o registro selecionado ?", "Exclusão Unidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    bll.Excluir(txtId.Text);
                    MessageBox.Show("A unidade foi excluida com sucesso!", "Excluido com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaTela();
                    CarregarGrid();
                }
            }
        }

        private void gridUnidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gridUnidade.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCnpj.Text = gridUnidade.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNome.Text = gridUnidade.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCodigoUf.Text = gridUnidade.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEndereco.Text = gridUnidade.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBairro.Text = gridUnidade.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNumero.Text = gridUnidade.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCep.Text = gridUnidade.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbMunici.Text = gridUnidade.Rows[e.RowIndex].Cells[8].Value.ToString();
            cbUf.Text = gridUnidade.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtTel.Text = gridUnidade.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtEmail.Text = gridUnidade.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCnpj.Clear();
            txtNome.Clear();
            txtCodigoUf.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtId.Clear();
            txtEmail.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
