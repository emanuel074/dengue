using controledengue.Code.DTO;
using DAL;
using System;
using System.Data;

namespace controledengue.Code.BLL
{
    class LoginBLL
    {
        AcessoBancoDados bd;

        public void Inserir(LoginDTO dto)
        {
            try
            {
                string nome = dto.Usuario.Replace("'", "'");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "insert into login (usuario, senha) values('" + dto.Usuario + "','" + dto.Senha + "')";
                bd.ExecutarComandoSQL(comando);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar usuário: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

        }

        public void Atualizar(LoginDTO dto)
        {
            try
            {
                string nome = dto.Senha.Replace("'", "'");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "update login set senha ='" + dto.novaSenha + "'where senha=" + dto.Senha;
                bd.ExecutarComandoSQL(comando);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar usuário: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

        }
        public void Excluir(string Id)
        {
            try
            {

                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "delete from login where id =" + Id;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao exluir um log: " + ex.Message);
            }
            finally
            {
                bd = null;

            }
        }
        public DataTable SelecionarAllLogs()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("select * from login");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar cadastrados " + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

        public DataTable SelecionarLogsUsuario(string usuario)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("select * from login where usuario ='" + usuario + "'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar cadastrados " + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }

        public DataTable SelecionarLogsId(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("select * from login where id ='" + id + "'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar cadastrados " + ex.Message);
            }
            finally
            {
                bd = null;
            }

            return dt;
        }
    }
}
