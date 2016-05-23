using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controledengue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if((txtUser.Text == "adm")&&(txtSenha.Text == "123"))
            {
                MessageBox.Show("Acesso permitido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 controle = new Form2();
                controle.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acesso negado!, Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
