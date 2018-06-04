using BibliotecaN2;
using BibliotecaN2.DAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace N2_AuQueMia.ClassesDAO
{
    public class AnimalBanhoDAO : PadraoDAO
    {
        SqlParameter[] parametros = new SqlParameter[6];
        public AnimalBanhoDAO()
        {
            Tabela = "AnimalBanho";
            Chave = "idAnimalBanho";
        }
        protected override SqlParameter[] CriaParametros(PadraoVO o, string manipula)
        {
            AnimalBanhoVO t = o as AnimalBanhoVO;
            parametros[0] = new SqlParameter("idConsulta", t.Id);
            parametros[1] = new SqlParameter("IdAnimal", t.IdAnimal);
            parametros[2] = new SqlParameter("idBanho", t.IdBanho);
            parametros[3] = new SqlParameter("dataBanho", t.DataBanho);
            parametros[4] = new SqlParameter("precoFinal", t.PrecoFinal);
            parametros[5] = new SqlParameter("manipulacao", manipula);

            return parametros;
        }
        protected override string Procedure()
        {
            return (""); //inserir sp do banco
        }
        protected override PadraoVO MontaVO(DataRow dr)
        {
            AnimalBanhoVO t = new AnimalBanhoVO();
            t.Id = Convert.ToInt32(dr["idConsulta"]);
            t.IdAnimal = Convert.ToInt32(dr["IdAnimal"]);
            t.IdBanho = Convert.ToInt32(dr["idBanho"]);
            t.DataBanho = Convert.ToDateTime(dr["dataBanho"]);
            t.PrecoFinal = Convert.ToDouble(dr["precoFinal"]);

            return t;
        }
        private static AnimalBanhoVO MontaAnimalBanhoVO(DataRow row)
        {
            AnimalBanhoVO t = new AnimalBanhoVO();
            t.Id = Convert.ToInt32(row["idConsulta"]);
            t.IdAnimal = Convert.ToInt32(row["IdAnimal"]);
            t.IdBanho = Convert.ToInt32(row["idBanho"]);
            t.DataBanho = Convert.ToDateTime(row["dataBanho"]);
            t.PrecoFinal = Convert.ToDouble(row["precoFinal"]);
            t.NomeAnimal = row[""].ToString(); //alterar
            t.DescricaoBanho = row[""].ToString(); //alterar

            return t;
        }
        public static List<AnimalBanhoVO> RetornaAnimalBanho() //alterar 
        {
            DataTable tabela = Metodos.ExecutaProcResultSet("", null);
            List<AnimalBanhoVO> lista = new List<AnimalBanhoVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaAnimalBanhoVO(registro));

            return lista;
        }

        public static List<AnimalBanhoVO> RetornaConsultasPorFiltros(int idAnimal, int idBanho, DateTime dataBanho) //alterar 
        {
            SqlParameter[] p =
            {
                new SqlParameter("", idAnimal),
                new SqlParameter("", idBanho),
                new SqlParameter("", dataBanho)
            };
            DataTable tabela = Metodos.ExecutaProcResultSet("", p);
            List<AnimalBanhoVO> lista = new List<AnimalBanhoVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaAnimalBanhoVO(registro));

            return lista;
        }
    }
}
