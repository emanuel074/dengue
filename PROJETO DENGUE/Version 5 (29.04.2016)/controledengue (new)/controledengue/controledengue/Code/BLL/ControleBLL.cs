
using controledengue.Code.DTO;
using DAL;
using System;
using System.Data;


namespace controledengue.Code.BLL
{
    class ControleBLL
    {
        AcessoBancoDados bd;

        public void Inserir(ControleDTO dto)
        {
            try
            {
                string nomeProfissional = dto.NomeProfissional.Replace("'", "'");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO cadastroAgente(nomeProfissional, idade, cpf, n_identidade, DataNascimentoProfissional, email, sexo, estadoCivil, endereçoProfissional, municipio, estado, telefone) VALUES ('" + nomeProfissional + "','" + dto.Idade + "','" + dto.Cpf + "','" + dto.N_identidade + "','" + dto.DataNascimentoProfissional1 + "','" + dto.Email + "','" + dto.Sexo + "','" + dto.EstadoCivil + "','" + dto.EndereçoProfissional + "','" + dto.Municipio + "','" + dto.Estado + "','" + dto.Telefone + "')";
                bd.ExecutarComandoSQL(comando);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar Agente: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

        }
        public void Atualizar(ControleDTO dto)
        {
            try
            {
                string nomeProfissional = dto.NomeProfissional.Replace("'", "'");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "UPDATE cadastroAgente set nomeProfissional ='" + nomeProfissional + "', idade ='" + dto.Idade + "', cpf ='" + dto.Cpf + "', n_identidade = '" + dto.N_identidade + "', DataNascimentoProfissional ='" + dto.DataNascimentoProfissional1 + "', email ='" + dto.Email + "', sexo ='" + dto.Sexo + "', estadoCivil ='" + dto.EstadoCivil + "', endereçoProfissional ='" + dto.EndereçoProfissional + "', municipio ='" + dto.Municipio + "', estado ='" + dto.Estado + "', telefone ='" + dto.Telefone + "' where codigoAgente =" + dto.CodigoAgente;
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

        public void Excluir(String CodigoAgente)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM cadastroAgente where codigoAgente =" + CodigoAgente;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o Agente: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }

        public DataTable Selecionar() 
        {
            DataTable dt = new DataTable();

            try
            {            

                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("select codigoAgente, nomeProfissional, idade, cpf, n_identidade, DataNascimentoProfissional, email, sexo, estadoCivil, endereçoProfissional, municipio, estado, telefone from cadastroAgente");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar Agente: " + ex.Message);
            }
            finally 
            {
                bd = null;
            }

            return dt;
        }
    }
}

