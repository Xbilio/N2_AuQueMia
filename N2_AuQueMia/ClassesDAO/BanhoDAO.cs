using BibliotecaN2;
using BibliotecaN2.DAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace N2_AuQueMia.ClassesDAO
{
    public class BanhoDAO : PadraoDAO
    {
        SqlParameter[] parametros = new SqlParameter[3];
        public BanhoDAO()
        {
            Tabela = "Banho";
            Chave = "idBanho";
        }
        protected override SqlParameter[] CriaParametros(PadraoVO o, string manipula)
        {
            BanhoVO t = o as BanhoVO;
            parametros[0] = new SqlParameter("idCargo", t.Id);
            parametros[1] = new SqlParameter("descricao", t.DescricaoBanho);
            parametros[2] = new SqlParameter("precoBase", t.PrecoBase);

            return parametros;
        }
        protected override string Procedure()
        {
            throw new Exception("não há manipulação de Cargos!");
        }
        protected override PadraoVO MontaVO(DataRow dr)
        {
            BanhoVO t = new BanhoVO();
            t.Id = Convert.ToInt32(dr["idEspecie"]);
            t.DescricaoBanho = dr["descricao"].ToString();
            t.PrecoBase = Convert.ToDouble(dr["precoBase"]);

            return t;
        }

        private static BanhoVO MontaBanhoVO(DataRow row)
        {
            BanhoVO t = new BanhoVO();
            t.Id = Convert.ToInt32(row["idEspecie"]);
            t.DescricaoBanho = row["descricao"].ToString();
            t.PrecoBase = Convert.ToDouble(row["precoBase"]);

            return t;
        }
        public static List<BanhoVO> RetornaBanhos()
        {
            DataTable tabela = Metodos.ExecutaProcResultSet("spRetornaTabelasEstaticas", null);
            List<BanhoVO> lista = new List<BanhoVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaBanhoVO(registro));

            return lista;
        }
    }
}
