using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAccess.DataBase
{
    public static class CriarBancoSql
    {
        public static void Executar()
        {
            var sql = @"IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'StockApp')
                        BEGIN
                           CREATE DATABASE StockApp
                        END";
        }
    }
}
