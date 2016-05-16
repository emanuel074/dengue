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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btCadAgente_Click(object sender, EventArgs e)
        {
            Form2 controle = new Form2();
            controle.Show();
            this.Hide();
        }

        private void btCadUni_Click(object sender, EventArgs e)
        {
            CadastrarUnidade controle = new CadastrarUnidade();
            controle.Show();
            this.Hide();
        }
        

        

        

        

      
    }
}
