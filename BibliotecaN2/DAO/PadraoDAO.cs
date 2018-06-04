using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaN2.DAO
{
    public abstract class PadraoDAO
    {              
        protected abstract SqlParameter[] CriaParametros(PadraoVO o, string manipula);

        protected abstract PadraoVO MontaVO(DataRow dr);

        protected string Tabela { get; set; }
        protected string Chave { get; set; } = "@id";  // valor default

        protected abstract string Procedure();        

        /// <summary>
        /// Método  para manipular registros
        /// </summary>        
        public virtual void Manipulacao(PadraoVO o, string manipula)
        {
            Metodos.ExecutaProcedure(Procedure(), CriaParametros(o, manipula));
        }
        
        /// <summary>
        /// Registro por um Id
        /// </summary>
        /// <returns></returns>
        public PadraoVO RetornaPorID(int id)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela),
                new SqlParameter("chave", Chave),
                new SqlParameter("id", id)
            };
            return ExecutaProcLocal("spRetornaPorID", parametros);
        }
        /// <summary>
        /// Registro por um Id
        /// </summary>
        /// <returns></returns>
        public List<PadraoVO> RetornaDados(int id)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela),
                new SqlParameter("chave", Chave),
                new SqlParameter("id", id)
            };
            return ExecutaListaProcLocal("spRetornaPorID", parametros);
        }
        /// <summary>
        /// Próximo Id
        /// </summary>
        /// <returns></returns>
        public virtual int RetornaProximoId()
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela)
            };
            DataTable tabela = Metodos.ExecutaProcResultSet("spRetornaProximoId", parametros);
            if (tabela.Rows.Count == 0)
                return 0;
            else
            {
                if(Convert.ToInt16(tabela.Rows[0]["PROXIMO"]) == 2)
                {
                    PadraoVO vo = RetornaPorID(1);
                    if (vo == null)
                        return 1;                                            
                }
                return Convert.ToInt16(tabela.Rows[0]["PROXIMO"]);
            }                            
        }
        /// <summary>
        /// Quantidade de registros
        /// </summary>
        /// <returns></returns>
        public virtual int Quantidade()
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela)
            };
            DataTable tabela = Metodos.ExecutaProcResultSet("spRetornaQuantidade", parametros);            
            return Convert.ToInt16(tabela.Rows[0]["QUANTIDADE"]);
        }
        /// <summary>
        /// Primeiro registro
        /// </summary>
        /// <returns></returns>
        public virtual PadraoVO Primeiro()
        {            
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela),
                new SqlParameter("chave", Chave)
            };
            return ExecutaProcLocal("spRetornaPrimeiro", parametros);
        }
        /// <summary>
        /// Ultimo registro
        /// </summary>
        /// <returns></returns>
        public virtual PadraoVO Ultimo()
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela),
                new SqlParameter("chave", Chave)
            };
            return ExecutaProcLocal("spRetornaUltimo", parametros);
        }
        /// <summary>
        /// Próximo registro
        /// </summary>
        /// <param name="atual"></param>
        /// <returns></returns>
        public virtual PadraoVO Proximo(int atual)
        {            
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela),
                new SqlParameter("chave", Chave),
                new SqlParameter("atual", atual)
            };
            return ExecutaProcLocal("spRetornaProximo", parametros);
        }
        /// <summary>
        /// Registro anterior
        /// </summary>
        /// <param name="atual"></param>
        /// <returns></returns>
        public virtual PadraoVO Anterior(int atual)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("tabela", Tabela),
                new SqlParameter("chave", Chave),
                new SqlParameter("atual", atual)
            };
            return ExecutaProcLocal("spRetornaAnterior", parametros);
        }
        /// <summary>
        /// Executa uma instrução SQL
        /// </summary>
        /// <param name="proc">instrução</param>
        /// <param name="parametros">parametros</param>
        /// <returns>Objeto PadraoVO</returns>
        protected PadraoVO ExecutaProcLocal(string proc, SqlParameter[] parametros)
        {
            DataTable tabela = Metodos.ExecutaProcResultSet(proc, parametros);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }
        /// <summary>
        /// Executa uma instrução SQL
        /// </summary>
        /// <param name="proc">instrução</param>
        /// <param name="parametros">parametros</param>
        /// <returns>Lista PadraoVO</returns>
        protected List<PadraoVO> ExecutaListaProcLocal(string proc, SqlParameter[] parametros)
        {
            DataTable tabela = Metodos.ExecutaProcResultSet(proc, parametros);
            List<PadraoVO> lista = new List<PadraoVO>();
            foreach (DataRow linha in tabela.Rows)
                lista.Add(MontaVO(linha));

            return lista;
        }

    }
}
