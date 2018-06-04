using System.Data.SqlClient;

namespace Mestre_Detalhe
{
    public class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=localhost;Initial Catalog=AulaDB;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}
