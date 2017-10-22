using SCAF.Model;
using System.Collections.ObjectModel;
using Xamarin.Forms.Xaml;

namespace SCAF.ViewModels
{
    
    public class FornecedorViewModel 
    {
        private Fornecedor _oldFornecedor;

        public ObservableCollection<Fornecedor> Fornecedor { get; set; }

        public FornecedorViewModel()
        {
            Fornecedor = new ObservableCollection<Fornecedor>
            {
                new Fornecedor{ NomeFantasia = "Coelba NeoEnergia", Cnpj= "073578787854", IsVisible = false}
            };
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
                _oldFornecedor.IsVisible = true;
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
    }
}
