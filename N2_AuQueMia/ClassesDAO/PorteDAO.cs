using BibliotecaN2;
using BibliotecaN2.DAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace N2_AuQueMia.ClassesDAO
{
    public class PorteDAO : PadraoDAO
    {
        SqlParameter[] parametros = new SqlParameter[3];
        public PorteDAO()
        {
            Tabela = "Porte";
            Chave = "idPorte";
        }
        protected override SqlParameter[] CriaParametros(PadraoVO o, string manipula)
        {
            PorteVO t = o as PorteVO;
            parametros[0] = new SqlParameter("idPorte", t.Id);
            parametros[1] = new SqlParameter("idRaca", t.IdRaca);
            parametros[2] = new SqlParameter("porte", t.Porte);

            return parametros;
        }
        protected override string Procedure()
        {
            throw new Exception("não há manipulação de Portes de animais!");
        }
        protected override PadraoVO MontaVO(DataRow dr)
        {
            PorteVO t = new PorteVO();
            t.Id = Convert.ToInt32(dr["idPorte"]);
            t.IdRaca = Convert.ToInt32(dr["idRaca"]);
            t.Porte = dr["porte"].ToString();

            return t;
        }
        private static PorteVO MontaPorteVO(DataRow row)
        {
            PorteVO t = new PorteVO();
            t.Id = Convert.ToInt32(row["idPorte"]);
            t.IdRaca = Convert.ToInt32(row["idRaca"]);
            t.Porte = row["porte"].ToString();

            return t;
        }
        public static List<PorteVO> RetornaPortes(int idRaca)
        {
            SqlParameter[] p = { new SqlParameter("idRaca", idRaca) };
            DataTable tabela = Metodos.ExecutaProcResultSet("spRetornaPortes", p);
            List<PorteVO> lista = new List<PorteVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaPorteVO(registro));

            return lista;
        }
    }
}
