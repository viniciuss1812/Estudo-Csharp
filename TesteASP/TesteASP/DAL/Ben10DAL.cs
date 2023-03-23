using Dapper;
using System.Data.SqlClient;
using TesteASP.Models;

namespace TesteASP.DAL
{
    public class Ben10DAL
    {
        private SqlConnection conexao;
        public Ben10DAL()
        {
            conexao = Conexao.GetConnection();
        }
        public List<Ben10> getTodosEpisodios() // Retorna a lista
        {
            string sql = "select * from episodios ";
            var dados = (List<Ben10>)conexao.Query<Ben10>(sql); //este código executa uma consulta SQL no
            return dados;                                                   //banco de dados utilizando a biblioteca Dapper e
                                                                            //armazena os resultados em uma lista de objetos do tipo "Ben10".
                                                                            //A lista é armazenada na variável "dados"
           
        } 
       
    }
}
