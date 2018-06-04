using BibliotecaN2;
using BibliotecaN2.DAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace N2_AuQueMia.ClassesDAO
{
    public class AnimalDAO : PadraoDAO
    {
        SqlParameter[] parametros = new SqlParameter[7];
        public AnimalDAO()
        {
            Tabela = "Animal";
            Chave = "idAnimal";
        }
        protected override SqlParameter[] CriaParametros(PadraoVO o, string manipula)
        {
            AnimalVO t = o as AnimalVO;
            parametros[0] = new SqlParameter("idAnimal", t.Id);
            parametros[1] = new SqlParameter("idResp", t.IdResp);
            parametros[2] = new SqlParameter("idRaca", t.IdRaca);
            parametros[3] = new SqlParameter("idPorte", t.IdPorte);
            parametros[4] = new SqlParameter("nome", t.Nome);            
            parametros[5] = new SqlParameter("preferencia", t.Preferencia);
            parametros[6] = new SqlParameter("manipulacao", manipula);

            return parametros;
        }
        protected override string Procedure()
        {
            return "spManipulaAnimal";
        }
        protected override PadraoVO MontaVO(DataRow dr)
        {
            AnimalVO t = new AnimalVO();
            t.Id = Convert.ToInt32(dr["idAnimal"]);
            t.IdResp = Convert.ToInt32(dr["idResp"]);
            t.IdRaca = Convert.ToInt32(dr["idRaca"]);
            t.IdPorte = Convert.ToInt32(dr["idPorte"]);
            t.Nome = dr["nome"].ToString();            
            t.Preferencia = dr["preferencia"].ToString();            

            return t;
        }
        private static AnimalVO MontaAnimalVO(DataRow row)
        {
            AnimalVO t = new AnimalVO();
            t.Id = Convert.ToInt32(row["idAnimal"]);
            t.IdResp = Convert.ToInt32(row["idResp"]);
            t.IdRaca = Convert.ToInt32(row["idRaca"]);
            t.IdPorte = Convert.ToInt32(row["idPorte"]);
            t.Nome = row["nome"].ToString();            
            t.Preferencia = row["preferencia"].ToString();
            t.Raca = row["raca"].ToString();
            t.Porte = row["porte"].ToString();
            t.IdEspecie = Convert.ToInt32(row["idEspecie"]);
            t.Especie = row["descricao"].ToString();

            return t;
        }
        public static List<AnimalVO> RetornaAnimaisPorResp(int idResponsavel)
        {
            SqlParameter[] p = { new SqlParameter("idResp", idResponsavel) };
            DataTable tabela = Metodos.ExecutaProcResultSet("spRetornaAnimaisPorResp", p);
            List<AnimalVO> lista = new List<AnimalVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaAnimalVO(registro));

            return lista;
        }

        public AnimalVO RetornaAnimaisPorId(int idAnimal)
        {
            SqlParameter[] p = { new SqlParameter("idAnimal", idAnimal) };
            DataTable tabela = Metodos.ExecutaProcResultSet("spRetornaAnimaisPorId", p);
                           
            return MontaAnimalVO(tabela.Rows[0]);
        }
    }
}
