using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controledengue.Code.View
{
    public partial class A2Z : Form
    {
        public A2Z()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BarraProgressoA2Z.Value < 100)
            {
                BarraProgressoA2Z.Value = BarraProgressoA2Z.Value + 2;

            }
            else
            {
                TempoBarraProgresso.Enabled = false;
                Login controle = new Login();
                controle.Show();
                this.Visible = false;               
            }
            {
                try
                {
                   
                }
                catch
                {
                    MessageBox.Show("Falha ao conectar com o servidor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void TelaA2Z_Click(object sender, EventArgs e)
        {

        }
    }
}