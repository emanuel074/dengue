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
using controledengue.Code;
using MySql;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace controledengue.Code.View
{
    public partial class CadastroLogin : MetroForm
    {
        public CadastroLogin()
        {
            InitializeComponent();
        }
        LoginBLL bll = new LoginBLL();
        LoginDTO dto = new LoginDTO();

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Login entrar = new Login();
            this.Hide();
            entrar.Show();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            dto.Usuario = tbUsuario.Text;
            dto.Senha = tbSenha.Text;

            if ((tbUsuario.Text == ""))
            {
                MessageBox.Show("Voce deve preencher todos os campos!", "FALHA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((tbSenha.Text == ""))
            {
                MessageBox.Show("Voce deve preencher todos os campos!", "FALHA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if ((tbConfirmarSenha.Text == tbSenha.Text))
            {
                string config = "server=127.0.0.1;userid=root;database=bancodengue";
                MySqlConnection conn = new MySqlConnection(config);
                MySqlCommand comando = new MySqlCommand();
                conn.Open();
                comando.Connection = conn;
                comando.CommandText = "select usuario from login where usuario = '" + dto.Usuario + "'";
                bool verifica = comando.ExecuteReader().HasRows;

                if (verifica == false)
                {
                    bll.Inserir(dto);
                    MessageBox.Show("O usuário foi cadastrado com sucesso!", "Bem vindo ao A2Z", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpartudo();
                    MenuInicial menu = new MenuInicial();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Esse usuário ja existe!", "FALHA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpartudo();
                }
                conn.Close();

            }

            else
            {
                MessageBox.Show("As senhas não se correspondem, tente novamente!", "FALHA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSenha.Clear();
                tbConfirmarSenha.Clear();
            }            

        }
        private void limpartudo()
        {
            tbSenha.Clear();
            tbUsuario.Clear();
            tbConfirmarSenha.Clear();
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            if (tbSenha.TextLength > 6)
            {
                MessageBox.Show("Ótimo! Sua senha é forte!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void CadastroLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Usu_Click(object sender, EventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
