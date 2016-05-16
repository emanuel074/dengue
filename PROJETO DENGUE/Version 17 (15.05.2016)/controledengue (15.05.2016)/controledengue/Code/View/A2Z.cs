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
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;

            }
            else
            {
                timer1.Enabled = false;
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

        
     
    }
}