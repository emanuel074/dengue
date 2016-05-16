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

namespace controledengue
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ControleBLL bll = new ControleBLL();
        ControleDTO dto = new ControleDTO();

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btInserir(object sender, EventArgs e)
        {
            dto.NomeProfissional = txtNome.Text;
            dto.Idade = int.Parse(txtIdade.Text);
            dto.Cpf = txtCpf.Text;
            dto.N_identidade = int.Parse(txtRg.Text);
            dto.DataNascimentoProfissional1 = mkdDataNasc.Text;
            dto.Email = txtEmail.Text;
            dto.Sexo = cbSexo.Text;
            dto.EstadoCivil = cbEstadoCivil.Text;
            dto.EndereçoProfissional = txtEndereco.Text;
            dto.Municipio = cbMunicipio.Text;
            dto.Estado = cbEstado.Text;
            dto.Telefone = mkdTelefone.Text;

            if (txtCod.Text == "")
            {
                bll.Inserir(dto);
                MessageBox.Show("O Agente foi cadastrado com sucesso!", "Salvo com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dto.CodigoAgente = int.Parse(txtCod.Text);
                bll.Atualizar(dto);
                MessageBox.Show("Atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LimparTela();
            CarregarGrid();
        }

        private void dataGridViewAgentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCod.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIdade.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCpf.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRg.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[4].Value.ToString();
            mkdDataNasc.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbSexo.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbEstadoCivil.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtEndereco.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[9].Value.ToString();
            cbMunicipio.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[10].Value.ToString();
            cbEstado.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[11].Value.ToString();
            mkdTelefone.Text = dataGridViewAgentes.Rows[e.RowIndex].Cells[12].Value.ToString();
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
            txtCpf.Clear();
            txtRg.Clear();
            mkdDataNasc.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            mkdTelefone.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarGrid();
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
            txtCpf.Clear();
            txtRg.Clear();
            mkdDataNasc.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            mkdTelefone.Clear();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                var result = MessageBox.Show("Deseja realmente excluir ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                LimparTela();

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    bll.Excluir(txtCod.Text);
                    CarregarGrid();
                }
            }
        }

        private void tpCadastro_Click(object sender, EventArgs e)
        {

        }

        private void txtDataNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMunicipio_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbMunNasc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}