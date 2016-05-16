using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controledengue.Code.DTO
{
    class UnidadeDTO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

   
        private string cnpj;

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }


        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string codUf;

        public string CodUf
        {
            get { return codUf; }
            set { codUf = value; }
        }


        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private int numFilial;

        public int NumFilial
        {
            get { return numFilial; }
            set { numFilial = value; }
        }

        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }


        private string uf;
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }


        private string municipio;

        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        private string telefone;
       

        public string Telefone
        {

            get { return telefone; }
            set { telefone = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
