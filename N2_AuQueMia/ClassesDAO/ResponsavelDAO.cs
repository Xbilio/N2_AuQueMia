using BibliotecaN2;
using BibliotecaN2.DAO;
using N2_AuQueMia.ClassesVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace N2_AuQueMia.ClassesDAO
{
    public class ResponsavelDAO : PadraoDAO
    {
        SqlParameter[] parametros = new SqlParameter[8];
        public ResponsavelDAO()
        {
            Tabela = "Responsavel";
            Chave = "idResp";
        }
        protected override SqlParameter[] CriaParametros(PadraoVO o, string manipula)
        {
            ResponsavelVO t = o as ResponsavelVO;
            parametros[0] = new SqlParameter("idResp", t.Id);
            parametros[1] = new SqlParameter("nome", t.Nome);
            parametros[2] = new SqlParameter("rg", t.Rg);
            parametros[3] = new SqlParameter("telefone", t.Telefone);
            parametros[4] = new SqlParameter("email", t.Email);
            parametros[5] = new SqlParameter("endereco", t.Endereco);
            parametros[6] = new SqlParameter("dataNasc", t.DataNasc);
            parametros[7] = new SqlParameter("manipulacao", manipula);

            return parametros;
        }
        protected override string Procedure()
        {            
            return "spManipulaResp";
        }        
        protected override PadraoVO MontaVO(DataRow dr)
        {
            ResponsavelVO t = new ResponsavelVO();
            t.Id = Convert.ToInt32(dr["idResp"]);
            t.Nome = dr["nome"].ToString();
            t.DataNasc = Convert.ToDateTime(dr["dataNasc"]);
            t.Rg = dr["rg"].ToString();
            t.Telefone = dr["telefone"].ToString();
            t.Email = dr["email"].ToString();
            t.Endereco = dr["endereco"].ToString();

            return t;
        }
        private static ResponsavelVO MontaRespVO(DataRow row)
        {
            ResponsavelVO t = new ResponsavelVO();
            t.Id = Convert.ToInt32(row["idResp"]);
            t.Nome = row["nome"].ToString();
            t.DataNasc = Convert.ToDateTime(row["dataNasc"]);
            t.Rg = row["rg"].ToString();
            t.Telefone = row["telefone"].ToString();
            t.Email = row["email"].ToString();
            t.Endereco = row["endereco"].ToString();

            return t;
        }
        public static List<ResponsavelVO> RetornaResponsaveis()
        {            
            DataTable tabela = Metodos.ExecutaProcResultSet("spRetornaResponsaveis", null);
            List <ResponsavelVO> lista = new List<ResponsavelVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaRespVO(registro));

            return lista;
        }
    }
}
