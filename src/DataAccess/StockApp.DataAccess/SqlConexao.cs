namespace StockApp.DataAccess
{
    internal static class SqlConexao
    {
        internal static string ConexaoSemBanco => @"server=.\SQLEXPRESS ; Integrated Security=True; User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
        
        internal static string ConexaoComBanco => @"Data Source=.\SQLEXPRESS;Initial Catalog=StockPhone;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
    }
}
