
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
                string comando = "INSERT INTO cadastroAgente(nomeProfissional, equipe, idade, cpf, n_identidade, DataNascimentoProfissional, email, sexo, estadoCivil, endereçoProfissional,bairroProfissional, N_residencia,municipio, estado, telefone,celular) VALUES ('" + nomeProfissional + "', '" + dto.Equipe + "','" + dto.Idade + "','" + dto.Cpf + "','" + dto.N_identidade + "','" + dto.DataNascimentoProfissional1 + "','" + dto.Email + "','" + dto.Sexo + "','" + dto.EstadoCivil + "','" + dto.EndereçoProfissional + "','" + dto.Bairro + "','" + dto.NumFilial + "','" + dto.Municipio + "','" + dto.Estado + "','" + dto.Telefone + "','" + dto.Celular + "')";
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

        //Novo 
        public void Atualizar(ControleDTO dto)
        {
            try
            {
                string nomeProfissional = dto.NomeProfissional.Replace("'", "'");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "UPDATE cadastroAgente set nomeProfissional = '" + dto.NomeProfissional + "', equipe ='" + dto.Equipe +"', idade ='" + dto.Idade + "', cpf ='" + dto.Cpf + "', n_identidade = '" + dto.N_identidade + "', DataNascimentoProfissional ='" + dto.DataNascimentoProfissional1 + "', email ='" + dto.Email + "', sexo ='" + dto.Sexo + "', estadoCivil ='" + dto.EstadoCivil + "', endereçoProfissional ='" + dto.EndereçoProfissional + "', bairroProfissional ='" + dto.Bairro + "', N_residencia ='" + dto.NumFilial + "',municipio ='" + dto.Municipio + "', estado ='" + dto.Estado + "', telefone ='" + dto.Telefone + "',celular ='" + dto.Celular + "' where codigoAgente =" + dto.CodigoAgente;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar o Agente:" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }

        //Novo 
        public DataTable pesquisarAgentePorNome(string nomeProfissional)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("select * from cadastroAgente where nomeProfissional ='" + nomeProfissional + "'");

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

        public void Excluir(string CodigoAgente)
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
                dt = bd.RetDataTable("select codigoAgente, nomeProfissional, equipe,  idade, cpf, n_identidade, DataNascimentoProfissional, email, sexo, estadoCivil, endereçoProfissional, bairroProfissional, N_residencia, municipio, estado, telefone, celular from cadastroAgente");
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

