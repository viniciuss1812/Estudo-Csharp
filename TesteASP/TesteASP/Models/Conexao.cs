using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TesteASP.Models
{
    public class Conexao
    {
        private static SqlConnection Banco;
        public static SqlConnection GetConnection()
        {
            if (Banco == null)
            {
                Banco = new SqlConnection(@"Data Source=DESKTOP-5A62GND\SQLEXPRESS;Initial Catalog=Ben10;Integrated Security=True");
            }
            return Banco;
        }
    }
}
