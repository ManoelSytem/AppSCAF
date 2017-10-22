using SCAF.Model;
using SCAF.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms.Xaml;

namespace SCAF.ViewModels
{
    
    public class FornecedorViewModel 
    {
        private Fornecedor _oldFornecedor;
        public List<Fornecedor> lisfornecedor;
        public ObservableCollection<Fornecedor> Fornecedor { get; set; }

        public ApiServiceFornecedor servicoFonecedor;
        public FornecedorViewModel()
        {
            ObterListaFornecedores();
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
            Fornecedor.Remove(fornecedor);
            Fornecedor.Insert(Index, fornecedor);
        }

        private async void ObterListaFornecedores()
        {   servicoFonecedor = new ApiServiceFornecedor();
            Fornecedor = new ObservableCollection<Fornecedor>();
            lisfornecedor = await servicoFonecedor.GetFornecedorsAsync();

            foreach (var fornecedor in lisfornecedor)
            {
                Fornecedor.Add(fornecedor);
            }
        }
    }
}
