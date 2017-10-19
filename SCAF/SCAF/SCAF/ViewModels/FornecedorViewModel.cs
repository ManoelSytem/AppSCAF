using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAF.ViewModels
{
    public class FornecedorViewModel : BaseViewModel
    {
        public string razaoSocial;
        public string RazaoSocial {   get{ return razaoSocial; } set{SetProperty(ref razaoSocial, value);}}

        public string nomeFantasia;
        public string NomeFantasia {  get { return nomeFantasia; } set { SetProperty(ref nomeFantasia, value); }}

        public string inscricaoEstadual;
        public string InscricaoEstadual { get { return inscricaoEstadual; } set { SetProperty(ref inscricaoEstadual, value); } }

        public string endereco;
        public string Endereco { get { return endereco; } set { SetProperty(ref endereco, value); } }

        public string email;
        public string Email { get { return email; } set { SetProperty(ref email, value); } }

        public string telefone;
        public string Telefone { get { return telefone; } set { SetProperty(ref telefone, value); } }
    }
}
