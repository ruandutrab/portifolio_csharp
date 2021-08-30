using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Portifolio_CSharp
{
    class Db
    {
        private static SQLiteConnection conexao;
        private static  SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection(@"Data Source="+ Extender.diretorioDb + Extender.NomeDataBase);
            conexao.Open();
            return conexao;
        }
    }
}
