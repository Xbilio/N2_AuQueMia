using System;

namespace Mestre_Detalhe
{
    class CaixaDetalheVO
    {
        public int Id { get; set; }

        public int CaixaId { get; set; }

        public DateTime Data { get; set; }

        public string Evento { get; set; }

        public double Entrada { get; set; }

        public double Saida { get; set; }


        /// <summary>
        /// Campo não existe na tabela
        /// </summary>
        public int dia { get; set; }

    }
}
