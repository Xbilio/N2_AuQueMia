using BibliotecaN2;
using BibliotecaN2.DAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace N2_AuQueMia.ClassesDAO
{
    public class EspecieDAO : PadraoDAO
    {
        SqlParameter[] parametros = new SqlParameter[2];
        public EspecieDAO()
        {
            Tabela = "Especie";
            Chave = "idEspecie";
        }
        protected override SqlParameter[] CriaParametros(PadraoVO o, string manipula)
        {
            EspecieVO t = o as EspecieVO;
            parametros[0] = new SqlParameter("idEspecie", t.Id);
            parametros[1] = new SqlParameter("descricao", t.Descricao);

            return parametros;
        }
        protected override string Procedure()
        {
            throw new Exception("não há manipulação de Espécies!");
        }
        protected override PadraoVO MontaVO(DataRow dr)
        {
            EspecieVO t = new EspecieVO();
            t.Id = Convert.ToInt32(dr["idEspecie"]);
            t.Descricao = dr["descricao"].ToString();                        

            return t;
        }

        private static EspecieVO MontaEspecieVO(DataRow row)
        {
            EspecieVO t = new EspecieVO();
            t.Id = Convert.ToInt32(row["idEspecie"]);
            t.Descricao = row["descricao"].ToString();

            return t;
        }
        public static List<EspecieVO> RetornaEspecies()
        {
            DataTable tabela = Metodos.ExecutaProcResultSet("spRetornaEspecies", null);
            List<EspecieVO> lista = new List<EspecieVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaEspecieVO(registro));

            return lista;
        }
    }
}
