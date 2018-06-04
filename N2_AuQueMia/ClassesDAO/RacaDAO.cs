using BibliotecaN2;
using BibliotecaN2.DAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace N2_AuQueMia.ClassesDAO
{
    public class RacaDAO : PadraoDAO
    {
        SqlParameter[] parametros = new SqlParameter[3];
        public RacaDAO()
        {
            Tabela = "Raca";
            Chave = "idRaca";
        }
        protected override SqlParameter[] CriaParametros(PadraoVO o, string manipula)
        {
            RacaVO t = o as RacaVO;
            parametros[0] = new SqlParameter("idRaca", t.Id);
            parametros[1] = new SqlParameter("idEspecie", t.IdEspecie);
            parametros[2] = new SqlParameter("descricao", t.Descricao);

            return parametros;
        }
        protected override string Procedure()
        {
            throw new Exception("não há manipulação de Raças de animais!");
        }
        protected override PadraoVO MontaVO(DataRow dr)
        {
            RacaVO t = new RacaVO();
            t.Id = Convert.ToInt32(dr["idRaca"]);
            t.IdEspecie = Convert.ToInt32(dr["idEspecie"]);
            t.Descricao = dr["descricao"].ToString();

            return t;
        }
        private static RacaVO MontaRacaVO(DataRow row)
        {
            RacaVO t = new RacaVO();
            t.Id = Convert.ToInt32(row["idRaca"]);
            t.IdEspecie = Convert.ToInt32(row["idEspecie"]);
            t.Descricao = row["descricao"].ToString();

            return t;
        }
        public static List<RacaVO> RetornaRacas(int idEspecie)
        {
            SqlParameter[] p = { new SqlParameter("idEspecie", idEspecie) };
            DataTable tabela = Metodos.ExecutaProcResultSet("spRetornaRacas", p);
            List<RacaVO> lista = new List<RacaVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaRacaVO(registro));

            return lista;
        }
    }
}
