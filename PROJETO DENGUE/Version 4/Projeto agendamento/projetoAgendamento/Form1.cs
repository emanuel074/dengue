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
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            gridagente.DataSource = bll.SelecionartodosAgentes();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            dto.Codigo = txtCodigo.Text;
            dto.Nome = txtNome.Text;
            dto.Bairro = txtBairro.Text;
            dto.Data_Visita = mktDataMarcada.Text;
            dto.Periodo = cmbPeriodo.Text;
            dto.Grupo = cmbGrupo.Text;

            if (txtCodigo.Text == "")
            {

                bll.Inserir(dto);
                MessageBox.Show("O agente foi cadastrado com sucesso", "Inserir com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dto.Codigo = txtCodigo.Text;
                bll.Atualizar(dto);
                MessageBox.Show("O agente foi atualizado com sucesso", "Atualização com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            bll.Inserir(dto);
            CarregarGrid();
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            mktDataMarcada.Clear();
            cmbPeriodo.Text = "";
            cmbGrupo.Text = "";
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
                }
            }
        }
    }
}
