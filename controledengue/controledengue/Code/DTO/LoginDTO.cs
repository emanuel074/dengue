using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controledengue.Code.DTO
{
    class LoginDTO
    {

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private string novasenha;
        public string novaSenha
        {
            get { return novasenha; }
            set { novasenha = value; }
        }

    }
}
