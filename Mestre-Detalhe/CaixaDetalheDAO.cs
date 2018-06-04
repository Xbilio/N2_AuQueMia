using System.Data.SqlClient;

namespace Mestre_Detalhe
{
    class CaixaDetalheDAO
    {
        public static void InsereCaixaDetalhe(CaixaDetalheVO cd)
        {
            string sql = "insert into CaixaDetalhe (CaixaId, data, evento, entrada, saida) " +
                "values (@CaixaId, @data, @evento, @entrada, @saida)";
            MetodosBD.ExecutaSQL(sql, CriaParametros(cd));
        }
        
        private static SqlParameter[] CriaParametros(CaixaDetalheVO cd)
        {
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("id", cd.Id);
            parametros[1] = new SqlParameter("caixaId", cd.CaixaId);
            parametros[2] = new SqlParameter("data", cd.Data);
            parametros[3] = new SqlParameter("evento", cd.Evento);
            parametros[4] = new SqlParameter("entrada", cd.Entrada);
            parametros[5] = new SqlParameter("saida", cd.Saida );
            return parametros;
        }

    }
}
