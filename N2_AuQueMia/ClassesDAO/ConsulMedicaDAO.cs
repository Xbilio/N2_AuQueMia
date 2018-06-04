using BibliotecaN2;
using BibliotecaN2.DAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace N2_AuQueMia.ClassesDAO
{
    public class ConsulMedicaDAO : PadraoDAO
    {
        SqlParameter[] parametros = new SqlParameter[6];
        public ConsulMedicaDAO()
        {
            Tabela = "Consulta";
            Chave = "idConsulta";
        }
        protected override SqlParameter[] CriaParametros(PadraoVO o, string manipula)
        {
            ConsulMedicaVO t = o as ConsulMedicaVO;
            parametros[0] = new SqlParameter("idConsulta", t.Id);
            parametros[1] = new SqlParameter("IdAnimal", t.IdAnimal);
            parametros[2] = new SqlParameter("IdVet", t.IdVet);
            parametros[3] = new SqlParameter("dataCon", t.DataConsulta);
            parametros[4] = new SqlParameter("descricao", t.Descricao);            
            parametros[5] = new SqlParameter("manipulacao", manipula);

            return parametros;
        }
        protected override string Procedure()
        {
            return(""); //inserir sp do banco
        }
        protected override PadraoVO MontaVO(DataRow dr)
        {
            ConsulMedicaVO t = new ConsulMedicaVO();
            t.Id = Convert.ToInt32(dr["idConsulta"]);
            t.IdAnimal = Convert.ToInt32(dr["IdAnimal"]);
            t.IdVet = Convert.ToInt32(dr["IdVet"]);
            t.DataConsulta = Convert.ToDateTime(dr["dataCon"]);
            t.Descricao = dr["descricao"].ToString();

            return t;
        }
        private static ConsulMedicaVO MontaConsultaMedicaVO(DataRow row)
        {
            ConsulMedicaVO t = new ConsulMedicaVO();
            t.Id = Convert.ToInt32(row["idConsulta"]);
            t.IdAnimal = Convert.ToInt32(row["idEspecie"]);
            t.IdVet = Convert.ToInt32(row["IdVet"]);
            t.DataConsulta = Convert.ToDateTime(row["dataCon"]);
            t.Descricao = row["descricao"].ToString();
            t.NomeAnimal = row[""].ToString(); //alterar
            t.NomeVet = row[""].ToString(); //alterar

            return t;
        }
        public static List<ConsulMedicaVO> RetornaConsultas() //alterar 
        {            
            DataTable tabela = Metodos.ExecutaProcResultSet("", null);
            List<ConsulMedicaVO> lista = new List<ConsulMedicaVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaConsultaMedicaVO(registro));

            return lista;
        }        

        public static List<ConsulMedicaVO> RetornaConsultasPorFiltros(int idAnimal, int idVeterinario, DateTime dataConsulta) //alterar 
        {
            SqlParameter[] p = 
            {
                new SqlParameter("", idAnimal),
                new SqlParameter("", idVeterinario),
                new SqlParameter("", dataConsulta)
            };
            DataTable tabela = Metodos.ExecutaProcResultSet("", p);
            List<ConsulMedicaVO> lista = new List<ConsulMedicaVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaConsultaMedicaVO(registro));

            return lista;
        }
    }
}
