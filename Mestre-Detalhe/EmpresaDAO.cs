using System;
using System.Collections.Generic;
using System.Data;

namespace Mestre_Detalhe
{
    class EmpresaDAO
    {  
        public static List<EmpresaVO> ConsultaEmpresas()
        {
            string sql = "select * from empresas order by Nome";
            DataTable tabela = MetodosBD.ExecutaSelect(sql, null);
            List<EmpresaVO> lista = new List<EmpresaVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaVO(registro));

            return lista;
        }

        private static EmpresaVO MontaVO(DataRow registro)
        {
            EmpresaVO obj = new EmpresaVO();
            obj.Id = Convert.ToInt32(registro["id"]);
            obj.Nome = registro["nome"].ToString();
            return obj;
        }
    }
}
