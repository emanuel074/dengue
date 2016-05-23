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
using MetroFramework.Forms;

//using controledenguee.Relatorios;

namespace controledengue.Code.View
{
    public partial class CadastrarUnidade : MetroForm
    {

        UnidadeBLL bll = new UnidadeBLL();
        UnidadeDTO dto = new UnidadeDTO();

        public CadastrarUnidade()
        {
            InitializeComponent();
        }
        
        private void CadastrarUnidade_Load(object sender, EventArgs e)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (mkdCnpj.Text != "" && txtNome.Text != "" && txtCodigoUf.Text != "" && txtEndereco.Text != "" && txtBairro.Text != "" && txtNumero.Text != "" && txtCep.Text != "" && cbUf.Text != "" && cbMunici.Text != "" && txtTel.Text != "" && txtEmail.Text != "")
            {

            dto.Cnpj = mkdCnpj.Text;
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


            bll.inserir(dto);
            MessageBox.Show("A unidade foi cadastrada com sucesso!", "Inserido com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpaTela();
            CarregarGrid();
            }

            else
            {
                MessageBox.Show("Para concluir o Cadastro da Unidade, preencha todos os campos.",
                 "Atenção",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation,
                 MessageBoxDefaultButton.Button1);
            }        
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (mkdCnpj.Text != "" && txtNome.Text != "" && txtCodigoUf.Text != "" && txtEndereco.Text != "" && txtBairro.Text != "" && txtNumero.Text != "" && txtCep.Text != "" && cbUf.Text != "" && cbMunici.Text != "" && txtTel.Text != "" && txtEmail.Text != "")
            {

            dto.Cnpj = mkdCnpj.Text;
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

            dto.Id = int.Parse(txtId.Text);

            bll.Atualizar(dto);
            MessageBox.Show("A unidade foi atualizada com sucesso!", "Atualizado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CarregarGrid();          
        }
            else
            {
                MessageBox.Show("Nenhuma Unidade selecionada!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private void CarregarGrid()
        {
            gridUnidade1.DataSource = bll.SelecionaTodasUnidades();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar ao menu principal ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MenuInicial controle = new MenuInicial();
                controle.Show();
                this.Hide();    
            }
        }

        private void LimpaTela()
        {
            mkdCnpj.Clear();
            txtNome.Clear();
            txtCodigoUf.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtTel.Clear();
            txtId.Clear();
            txtEmail.Clear();
            cbUf.Text = "";
            cbMunici.Text = "";
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
                else
                {
                    MessageBox.Show("Selecione a Unidade para apagar!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void gridUnidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gridUnidade1.Rows[e.RowIndex].Cells[0].Value.ToString();
            mkdCnpj.Text = gridUnidade1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNome.Text = gridUnidade1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCodigoUf.Text = gridUnidade1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEndereco.Text = gridUnidade1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBairro.Text = gridUnidade1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNumero.Text = gridUnidade1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCep.Text = gridUnidade1.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbMunici.Text = gridUnidade1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cbUf.Text = gridUnidade1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtTel.Text = gridUnidade1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtEmail.Text = gridUnidade1.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mkdCnpj.Clear();
            txtNome.Clear();
            txtCodigoUf.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtId.Clear();
            txtEmail.Clear();
            cbUf.Text = "";
            cbMunici.Text = "";
            txtTel.Clear();
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar ao menu principal ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MenuInicial controle = new MenuInicial();
                controle.Show();
                this.Hide();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia nº e espaço
            if ((Char.IsNumber(e.KeyChar)) )
                e.Handled = true;
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia nº e espaço
            if ((Char.IsNumber(e.KeyChar)) )
                e.Handled = true;
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia nº e espaço
            if ((Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia  espaço
            if ((Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloquia letras e espaço 
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtCodigoUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloquia letras e espaço 
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
        private void cbUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbMunici_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueia nº e espaço
            if ((Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void tpCadastro_Click(object sender, EventArgs e)
        {

        }

        private void gridUnidade_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtBairro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
