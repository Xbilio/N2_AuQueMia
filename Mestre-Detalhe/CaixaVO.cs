using System;
using System.Collections.Generic;

namespace Mestre_Detalhe
{
    class CaixaVO
    {
        public int Id { get; set; }

        public int EmpresaId { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }

        /// <summary>
        /// Este campo não existe na tabela
        /// </summary>
        public List<CaixaDetalheVO> DetalhesCaixa { get; set; } = new List<CaixaDetalheVO>();
    }
}
