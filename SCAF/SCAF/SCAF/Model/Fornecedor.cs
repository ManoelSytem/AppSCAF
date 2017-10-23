using System.ComponentModel;

namespace SCAF.Model
{
    public class Fornecedor 
    {
        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public string InscricaoEstadual { get; set; }

        public string Cnpj { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Categoria { get; set; }

        public bool IsVisible { get; set; }

    }
}
