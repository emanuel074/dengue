using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using controledengue.Code.DTO;
using DAL;
using System.Data;
using controledengue.Code.BLL;




namespace controledengue.Code.BLL
{
    class AgendamentoBLL
    {

        AcessoBancoDados bd;

        public void Inserir(AgendamentoDTO dto)
        {
            try
            {
                string codigo = dto.Codigo.Replace("'", "'");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO Agendamento (Codigo, Nome, Bairro, Data_Visita, Periodo, Grupo) VALUES ('" + dto.Codigo + "', '" + dto.Nome + "','" + dto.Bairro + "','" + dto.Data_Visita + "' , '" + dto.Periodo + "','" + dto.Grupo + "')";
                bd.ExecutarComandoSQL(comando);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tenta incluir um agente: " + ex.Message);
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
                dt = bd.RetDataTable("select Codigo, Nome, Bairro, Data_Visita, Periodo, Grupo from Agendamento");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar todos os agentes: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

        public void Excluir(string Codigo)
        {
            try
            {

                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM Agendamento where codigo =" + Codigo;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tenta exluir um agente: " + ex.Message);
            }
            finally
            {
                bd = null;

            }


        }
        public void Atualizar(AgendamentoDTO dto)
        {
            try
            {
                string Codigo = dto.Codigo.Replace("'", "'");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "UPDATE Agendamento set Codigo ='" + dto.Codigo + "', Nome ='" + dto.Nome + "', Bairro ='" + dto.Bairro + "', Data_Visita = '" + dto.Data_Visita + "', Periodo ='" + dto.Periodo + "', Grupo ='" + dto.Grupo + "' where Codigo =" + dto.Codigo;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar o Agente: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }


        public DataTable pesquisarAgentePorNome(string nome)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("select * from Agendamento where nome ='" + nome + "'");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar os nomes: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

    }
}





