using BibliotecaN2.DAO;
using System;

namespace N2_AuQueMia.ClassesVO
{
    public class AnimalBanhoVO : PadraoVO
    {
        public int IdBanho { get; set; }
        public int IdAnimal { get; set; }
        public DateTime DataBanho { get; set; }
        public double PrecoFinal { get; set; }

        //Campos que não estão na tabela do BD
        public string NomeAnimal { get; set; }
        public string DescricaoBanho { get; set; } 
    }
}