using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controledengue.Code.DTO
{
    class ControleDTO
    {
        private int codigoAgente;

        public int CodigoAgente
        {
            get { return codigoAgente; }
            set { codigoAgente = value; }
        }

        private string nomeProfissional;

        public string NomeProfissional
        {
            get { return nomeProfissional; }
            set { nomeProfissional = value; }
        }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private int n_identidade;

        public int N_identidade
        {
            get { return n_identidade; }
            set { n_identidade = value; }
        }

        private string DataNascimentoProfissional;

        public string DataNascimentoProfissional1
        {
            get { return DataNascimentoProfissional; }
            set { DataNascimentoProfissional = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string estadoCivil;

        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        private string endereçoProfissional;

        public string EndereçoProfissional
        {
            get { return endereçoProfissional; }
            set { endereçoProfissional = value; }
        }

        private string municipio;

        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }



    }
}
