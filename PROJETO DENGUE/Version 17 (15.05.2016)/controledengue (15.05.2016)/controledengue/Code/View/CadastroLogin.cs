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

namespace controledengue.Code.View
{
    public partial class CadastroLogin : Form
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
                bll.Inserir(dto);
                MessageBox.Show("O usuário foi cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpartudo();
                MenuInicial entrar = new MenuInicial();
                this.Hide();
                entrar.Show();
                MessageBox.Show("Bem vindo ao A2Z!", "Olá!", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

      
    }
}
