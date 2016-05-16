using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controledengue.Code.DTO
{
    class AgendamentoDTO
    {
        private string codigo;
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }

        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }

        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }

        }
        private string data_visita;
        public string Data_Visita
        {
            get { return data_visita; }
            set { data_visita = value; }

        }
        private string periodo;
        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }

        }
        private string grupo;
        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }

        }
    }
}
