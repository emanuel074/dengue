using controledengue.Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace controledengue.Code.BLL
{
    class UnidadeBLL
    {
        AcessoBancoDados bd = new AcessoBancoDados();


        public void inserir(UnidadeDTO dto)
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO cadastro_unidade ( cnpj,nome_Fantasia,Codigo_uf, endereco_filial,bairro_filial,N_filial,cep,municipio_filial,estado_filial,tel_filial,email_filial) VALUES ('" + dto.Cnpj + "','" + dto.Nome + "','" + dto.CodUf + "','" + dto.Endereco + "','" + dto.Bairro + "','" + dto.NumFilial + "', '" + dto.Cep + "', '" + dto.Municipio + "','" + dto.Uf + "', '" + dto.Telefone + "','" + dto.Email + "')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar cadastrar a unidade:" + ex.Message);
            }
            finally
            {
                bd = null;

            }
        }

        public DataTable SelecionaTodasUnidades()
        {
            DataTable dt = new DataTable();
            try
            {

                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("Select id_filial, cnpj,nome_Fantasia,Codigo_uf, endereco_filial,bairro_filial,N_filial,cep,municipio_filial,estado_filial,tel_filial,email_filial from cadastro_unidade");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar todas as unidades:" + ex.Message);
            }
            finally
            {
                bd = null;

            }
            return dt;

        }

        public void Atualizar(UnidadeDTO dto)
        {

            try
            {
                string nome = dto.Nome.Replace("'", "''");
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "UPDATE cadastro_unidade set cnpj = '" + dto.Cnpj + "',nome_Fantasia = '" + dto.Nome + "',Codigo_uf = '" + dto.CodUf + "', endereco_filial = '" + dto.Endereco + "', bairro_filial = '" + dto.Bairro + "',N_filial = '" + dto.NumFilial + "', cep = '" + dto.Cep + "',municipio_filial = '" + dto.Municipio + "',estado_filial = '" + dto.Uf + "',tel_filial = '" + dto.Telefone + "',email_filial = '" + dto.Email + "' where id_filial =" + dto.Id;

                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar atualizar a unidade:" + ex.Message);
            }
            finally
            {
                bd = null;

            }
        }

        public void Excluir(string id)
        {
            //'" + nome + "','" + dto.Email + "'
            try
            {

                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM cadastro_unidade where id_filial =" + id;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir a unidade:" + ex.Message);
            }
            finally
            {
                bd = null;

            }
        }
    }
}
