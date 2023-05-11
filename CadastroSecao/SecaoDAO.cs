using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSecao
{
    public class SecaoDAO
    {
        private SqlConnection Connection { get; }

        public SecaoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public void Salvar(SecaoModel secao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibSecao(descricaoSecao) VALUES(@descricaoSecao)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@descricaoSecao", secao.NomeSecao));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Editar(SecaoModel secao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibSecao SET descricaoSecao = @descricaoSecao WHERE codSecao = @codSecao");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codSecao", secao.CodSecao);
                    command.Parameters.Add(new SqlParameter("@descricaoSecao", secao.NomeSecao));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Excluir(SecaoModel secao, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtBibSecao WHERE codSecao = @codSecao");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@codSecao", secao.CodSecao));
                command.ExecuteNonQuery();
            }
        }

        public int VerificaRegistros(SecaoModel secao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codSecao) FROM mvtBibSecao WHERE codSecao = @codSecao");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codSecao", secao.CodSecao);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }

        public List<SecaoModel> GetSecoes()
        {
            List<SecaoModel> secoes = new List<SecaoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT SEC.codSecao, SEC.descricaoSecao FROM mvtBibSecao LOC ORDER BY LOC.codSecao");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        secoes.Add(PopulateDr(dr));
                    }
                }
            }
            return secoes;
        }

        public SecaoModel PopulateDr(SqlDataReader dr)
        {
            string codSecao = "";
            string nomeSecao = "";

            if (DBNull.Value != dr["codSecao"])
            {
                codSecao = dr["codSecao"] + "";
            }
            if (DBNull.Value != dr["descricaoSecao"])
            {
                nomeSecao = dr["descricaoSecao"] + "";
            }
            return new SecaoModel()
            {
                CodSecao = codSecao,
                NomeSecao = nomeSecao
            };
        }
    }
}
