using System;
using System.Windows.Forms;
using DAL;
using System.Data;
using MetroFramework.Forms;
namespace controledengue.Code.View
{

    public partial class MenuInicial : MetroForm
    {
        AcessoBancoDados bd;
                
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void btCadAgente_Click(object sender, EventArgs e)
        {
            ControleAgente controle = new ControleAgente();
            controle.Show();
            this.Hide();
        }

        private void btCadUni_Click(object sender, EventArgs e)
        {
            CadastrarUnidade controle = new CadastrarUnidade();
            controle.Show();
            this.Hide();
        }

        private void btAgenda_Click(object sender, EventArgs e)
        {          
            Agendamento controleVisita = new Agendamento();
            controleVisita.Show();
            this.Hide();
        }

        private void redefinirSenhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RedefinirSenha controleVisita = new RedefinirSenha();
            controleVisita.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre controleVisita = new Sobre();
            controleVisita.Show();
            this.Hide();
        }

        private void entrarComOutraContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login controle = new Login();
            controle.Show();
            this.Hide();
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("select * from login");
            }
            catch
            {
                MessageBox.Show("Falha ao conectar com o servidor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {           
                MessageBox.Show("Não se esqueça de ler as observações no canto superior das telas!", "AJUDA", MessageBoxButtons.OK, MessageBoxIcon.Information);               
        }

        private void redefinirSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("select * from login");
            }
            catch
            {
                MessageBox.Show("Falha ao conectar com o servidor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {
           
        }
    }
}
