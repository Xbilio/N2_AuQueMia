using System.Data.SqlClient;

namespace Mestre_Detalhe
{
    static class CaixaDAO
    {
        /// <summary>
        /// Insere o pedido e seus itens
        /// </summary>
        /// <param name="pedido"></param>
        public static int Insere(CaixaVO c)
        {
            //transações
            //https://msdn.microsoft.com/pt-br/library/system.transactions.transactionscope(v=vs.110).aspx            

            using (var transacao = new System.Transactions.TransactionScope()) // início da transação
            {
                string sql = "insert into caixa (empresaId, mes, ano) values (@empresaId, @mes, @ano)";
                int ultimoId = MetodosBD.ExecutaSQL(sql, CriaParametros(c));

                foreach (CaixaDetalheVO item in c.DetalhesCaixa)
                {
                    item.CaixaId = ultimoId;
                    CaixaDetalheDAO.InsereCaixaDetalhe(item);
                }
                transacao.Complete(); // efetua o commit. Se der uma exception neste código, ou ele não passar por esta linha, será considerado rollback

                return ultimoId;
            }
        }


        private static SqlParameter[] CriaParametros(CaixaVO c)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("id", c.Id);
            parametros[1] = new SqlParameter("empresaId", c.EmpresaId);
            parametros[2] = new SqlParameter("mes", c.Mes);
            parametros[3] = new SqlParameter("ano", c.Ano);
            return parametros;
        }
    }
}
