using SCAF.Model;
using SCAF.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SCAF.ViewModels
{
       
    public class FornecedorViewModel : NotificarBase
    {

        public string nomeFantasia;
        public string NomeFantasia { get { return nomeFantasia; } set { nomeFantasia = value; Notificar(); } }
        public string inscricaoEstadual;
        public string InscricaoEstadual { get { return inscricaoEstadual; } set { inscricaoEstadual = value; Notificar(); } }
        public string cnpj;
        public string Cnpj { get { return cnpj; } set { cnpj = value; Notificar(); } }
        public string endereco;
        public string Endereco { get { return endereco; } set { endereco = value; Notificar(); } }
        public string email;
        public string Email { get { return email; } set { email = value; Notificar(); } }
        public string telefone;
        public string Telefone { get { return telefone; } set { telefone = value; Notificar(); } }
        public string razaoSocial;
        public string RazaoSocial { get { return razaoSocial; } set { razaoSocial = value; Notificar(); } }
        public string categoria;
        public string Categoria { get { return categoria; } set { categoria = value; Notificar(); } }


        private Fornecedor _oldFornecedor;
        public List<Fornecedor> lisfornecedor;
        private ObservableCollection<Fornecedor> fornecedor;
        public ObservableCollection<Fornecedor> Fornecedor
        {
            get { return fornecedor; }
            set
            {
               
                    fornecedor = value;
                    Notificar();
            }
        }
        public ApiServiceFornecedor servicoFonecedor;

        public FornecedorViewModel()
        {
            Fornecedor = new ObservableCollection<Fornecedor> {
               new Fornecedor
               {
                NomeFantasia = "Coelba",
                Cnpj = "84.805.205/0001-34",
                Categoria = "Energia Elétrica"
               },
               new Fornecedor
               {
                NomeFantasia = "Stefanini",
                Cnpj = "65.182.980/0001-36",
                Categoria = "Tecnologia"
               }
            };
            // ObterListaFornecedores();
        }

        public void HideOrShowFornecedor(Fornecedor fornecedor)
        {
            if (_oldFornecedor == fornecedor)
            {
                fornecedor.IsVisible = !fornecedor.IsVisible;
                UpdateFornecedor(fornecedor);
            }
            else
            {
                if (_oldFornecedor != null)
                {
                    _oldFornecedor.IsVisible = false;
                    UpdateFornecedor(fornecedor);
                }
                fornecedor.IsVisible = true;
                UpdateFornecedor(fornecedor);
            }

            _oldFornecedor = fornecedor;
        }

        private void UpdateFornecedor(Fornecedor fornecedor)
        {
            var Index = Fornecedor.IndexOf(fornecedor);
            if (Index != -1)
            {
                Fornecedor.Remove(fornecedor);
                Fornecedor.Insert(Index, fornecedor);
            }else
            {
                var caunt = Fornecedor.Count;
                fornecedor.IsVisible = false;
                Fornecedor.Insert(caunt, fornecedor);
            }
        }

        private async void ObterListaFornecedores()
        {
            servicoFonecedor = new ApiServiceFornecedor();
            Fornecedor = new ObservableCollection<Fornecedor>();
            lisfornecedor = await servicoFonecedor.GetFornecedorsAsync();

            foreach (var fornecedor in lisfornecedor)
            {
                Fornecedor.Add(fornecedor);
            }
        }

        public void DetalhaFornecedor(Fornecedor forn)
        {
            NomeFantasia = forn.NomeFantasia;
        }

    }
}
