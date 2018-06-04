using BibliotecaN2.DAO;
using System;

namespace N2_AuQueMia.ClassesVO
{
    public class ConsulMedicaVO : PadraoVO
    {
        public int IdAnimal { get; set; }
        public int IdVet { get; set; }       
        public DateTime DataConsulta { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }        
        //Campos que nao pertencem a tabela no BD
        public string NomeAnimal { get; set; }
        public string NomeVet { get; set; }
    }
}
