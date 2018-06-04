using BibliotecaN2.DAO;
using System;

namespace N2_AuQueMia.ClassesVO
{
    public class ResponsavelVO : PadraoVO
    {
        public string Nome { get; set; }
        public string Rg { get; set; }
        public DateTime DataNasc { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
