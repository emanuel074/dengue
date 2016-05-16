using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoAgendamento.Code.DTO;
using DAL;
using DAL;
using System.Data;



namespace projetoAgendamento.Code.BLL
{
    class Agente_BLL
    {

        AcessoBancoDados bd;

        public void Inserir(Agente_DTO dto)
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO Agendamento(Codigo,Nome,Bairro,Data_Visita,Periodo,Grupo) VALUES('" + dto.Codigo + "','" + dto.Nome + "','" + dto.Bairro + "','" + dto.Data_Visita + "' , '" + dto.Periodo + "','" + dto.Grupo + "')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tenta incluir um agente:" + ex.Message);
            }
            finally
            {
                bd = null;
               
            }

           
       }

        public DataTable SelecionartodosAgentes()
        {
            DataTable dt = new DataTable();
            try
            {
               
                bd = new AcessoBancoDados();
                bd.Conectar();
               

                dt = bd.RetDataTable("SELECT Codigo,Nome,Bairro,Data_Visita,Periodo,Grupo from Agendamento ");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tenta selecionar todos os agentes: " + ex.Message);
            }
            finally
            {
               bd = null;
            }
            return dt;
        }

        public void Atualizar(Agente_DTO dto)
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "UPDATE Agendamento set nome = '" + dto.Nome + "', bairro = '" + dto.Bairro + "', data_visita = '" + dto.Data_Visita + "',periodo = '" + dto.Periodo + "',grupo = '" + dto.Grupo + "' where codigo =" + dto.Codigo;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tenta atualizar um agente:" + ex.Message);
            }
            finally
            {
                bd = null;

            }
        }

             public void Excluir(string Codigo)
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM  Agendamento where codigo =" + dto.Codigo;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tenta exluir um agente:" + ex.Message);
            }
            finally
            {
                bd = null;

            }
        }



    }

    }

}

