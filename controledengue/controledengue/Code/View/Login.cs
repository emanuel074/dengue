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
using controledengue.Code.View;
using MySql;
using MySql.Data.MySqlClient;
using DAL;
using MetroFramework.Forms;

namespace controledengue
{
    public partial class Login : MetroForm
    {
        AcessoBancoDados bd;

        public Login()
        {
            InitializeComponent();
        }

        LoginBLL bll = new LoginBLL();
        LoginDTO dto = new LoginDTO();

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastroLogin formCadastro = new CadastroLogin();
            this.Hide();
            formCadastro.Show();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string senha = tbSenha.Text;
            string config = "server=127.0.0.1;userid=root;database=bancodengue";
            MySqlConnection conn = new MySqlConnection(config);
            MySqlCommand comando = new MySqlCommand();
            conn.Open();
            comando.Connection = conn;
            comando.CommandText = "select usuario,senha from login where usuario = '" + usuario + "' and senha ='" + senha + "'";
            bool verifica = comando.ExecuteReader().HasRows;

            if (verifica == true)
            {
                MessageBox.Show("Bem vindo !", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuInicial novo = new MenuInicial();
                this.Hide();
                novo.Show();                

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos, tente novamente!", "FALHA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSenha.Clear();
            }
            conn.Close();
        }


        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }  
        }

        private void Login_Load(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}