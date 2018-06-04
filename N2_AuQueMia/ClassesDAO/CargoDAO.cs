using BibliotecaN2;
using BibliotecaN2.DAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace N2_AuQueMia.ClassesDAO
{
    public class CargoDAO : PadraoDAO
    {
        SqlParameter[] parametros = new SqlParameter[2];
        public CargoDAO()
        {
            Tabela = "Cargo";
            Chave = "idCargo";
        }
        protected override SqlParameter[] CriaParametros(PadraoVO o, string manipula)
        {
            CargoVO t = o as CargoVO;
            parametros[0] = new SqlParameter("idCargo", t.Id);
            parametros[1] = new SqlParameter("descricao", t.Descricao);

            return parametros;
        }
        protected override string Procedure()
        {
            throw new Exception("não há manipulação de Cargos!");
        }
        protected override PadraoVO MontaVO(DataRow dr)
        {
            CargoVO t = new CargoVO();
            t.Id = Convert.ToInt32(dr["idEspecie"]);
            t.Descricao = dr["descricao"].ToString();

            return t;
        }

        private static CargoVO MontaCargoVO(DataRow row)
        {
            CargoVO t = new CargoVO();
            t.Id = Convert.ToInt32(row["idEspecie"]);
            t.Descricao = row["descricao"].ToString();

            return t;
        }
        public static List<CargoVO> RetornaCargos()
        {
            DataTable tabela = Metodos.ExecutaProcResultSet("spRetornaTabelasEstaticas", null);
            List<CargoVO> lista = new List<CargoVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaCargoVO(registro));

            return lista;
        }
    }
}
