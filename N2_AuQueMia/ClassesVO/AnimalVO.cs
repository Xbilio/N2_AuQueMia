using BibliotecaN2.DAO;

namespace N2_AuQueMia.ClassesVO
{
    public class AnimalVO : PadraoVO
    {
        public int IdResp { get; set; }
        public int IdRaca { get; set; }
        public int IdPorte { get; set; }
        public string Nome { get; set; }                
        public string Preferencia { get; set; }    
        
        //Campos não existentes na tabela Animal       
        public string Raca { get; set; }
        public string Porte { get; set; }
        public int IdEspecie { get; set; }
        public string Especie { get; set; }
    }
}