using Dapper;
using Microsoft.Data.SqlClient;

namespace StockApp.DataAccess.DataBase
{
    public partial class DatabaseService
    {
        public void CriarTabelaCategoria()
        {
            var tabelaExiste = VerificarExistenciaTabela();

            if (!tabelaExiste)
            {
                CriarTabela();
            }
            else
            {
                VerificarExistenciaTabela();
            }
        }
        private bool VerificarExistenciaTabela()
        {
            using (var conexao = new SqlConnection(SqlConexao.ConexaoComBanco))
            {
                conexao.Open();

                var query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Categorias'";
                var resultado = conexao.ExecuteScalar<int>(query);

                return resultado > 0;
            }
        }
        private void CriarTabela()
        {
            var sql = @"CREATE TABLE Categorias
                        (
                            Id int,
                            Nome varchar(100)
                        )";

            using (var conexao = new SqlConnection(SqlConexao.ConexaoComBanco))
            {
                conexao.Open();

                conexao.Execute(sql);
            }
        }
        private void VerificarEAtualizarColunas()
        {
            using (var conexao = new SqlConnection(SqlConexao.ConexaoComBanco))
            {
                conexao.Open();

                var query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Categorias'";
                var colunasExistentes = conexao.Query<string>(query).ToList();

                if (!colunasExistentes.Contains("Id"))
                {
                    AdicionarColuna("Id", "int");
                }

                if (!colunasExistentes.Contains("Nome"))
                {
                    AdicionarColuna("Nome", "varchar(100)");
                }
            }
        }
        private void AdicionarColuna(string nomeColuna, string tipoColuna)
        {
            var sql = $"ALTER TABLE Categorias ADD {nomeColuna} {tipoColuna}";

            using (var conexao = new SqlConnection(SqlConexao.ConexaoComBanco))
            {
                conexao.Open();

                conexao.Execute(sql);
            }
        }
        public static string PopularTabela()
        {
            return "";
        }
    }
}
