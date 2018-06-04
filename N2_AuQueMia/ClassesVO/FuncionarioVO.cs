using BibliotecaN2.DAO;
using System;

namespace N2_AuQueMia.ClassesVO
{
    public class FuncionarioVO : PadraoVO
    {
        public string Nome { get; set; }
        public string Rf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNasc { get; set; }
        public double Salario { get; set; }
        public DateTime Admissao { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Escala { get; set; }
        public string Foto { get; set; }
        //Campos que nao pertencem a tabela no BD
        public string Cargo { get; set; }
    }
}
