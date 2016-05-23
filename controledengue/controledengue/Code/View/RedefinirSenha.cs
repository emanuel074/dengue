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
using DAL;
using MetroFramework.Forms;
namespace controledengue.Code.View
{
    public partial class RedefinirSenha : MetroForm
    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }

        LoginBLL bll = new LoginBLL();
        LoginDTO dto = new LoginDTO();

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Login menu = new Login();
            this.Hide();
            menu.Show();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dto.Senha = tbNovaSenha.Text;

            if ((tbSenha.Text == ""))
            {
                MessageBox.Show("Voce deve preencher todos os campos!", "FALHA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((tbNovaSenha.Text == ""))
            {
                MessageBox.Show("Voce deve preencher todos os campos!", "FALHA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if ((tbConfirmarSenha.Text == tbNovaSenha.Text))
            {
                dto.Senha = tbSenha.Text;
                dto.novaSenha = tbNovaSenha.Text;
                string config = "server=127.0.0.1;userid=root;database=bancodengue";
                MySqlConnection conn = new MySqlConnection(config);
                MySqlCommand comando = new MySqlCommand();
                conn.Open();
                comando.Connection = conn;
                comando.CommandText = "select * from login where senha ='" + dto.Senha + "'";
                bool verifica = comando.ExecuteReader().HasRows;

                if (verifica == true)
                {
                    bll.Atualizar(dto);
                    MessageBox.Show("Sua senha foi alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpartudo();
                    Login menu = new Login();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Senha do usuario incorreta! Tente novamente!", "FALHA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpartudo();
                }
                conn.Close();

            }

            else
            {
                MessageBox.Show("As senhas não se correspondem, tente novamente!", "FALHA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNovaSenha.Clear();
                tbConfirmarSenha.Clear();
            }
        }

        private void limpartudo()
        {
            tbSenha.Clear();
            tbConfirmarSenha.Clear();
            tbNovaSenha.Clear();
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbNovaSenha_KeyPress(object sender, KeyPressEventArgs e)
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

        private void RedefinirSenha_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
