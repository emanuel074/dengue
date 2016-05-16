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
    public partial class DicasPrevenção : Form
    {
        public DicasPrevenção()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuInicial novo = new MenuInicial();
            this.Hide();
            novo.Show();
        }
    }
}
