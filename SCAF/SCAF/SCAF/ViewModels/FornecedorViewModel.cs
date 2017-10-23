using SCAF.Model;
using SCAF.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCAF.ViewModels
{
       
    public class FornecedorViewModel : INotifyPropertyChanged
    {
        public string NomeFantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string RazaoSocial { get; set; }
        public string Categoria { get; set; }

        private Fornecedor _oldFornecedor;
        public List<Fornecedor> lisfornecedor;
        private ObservableCollection<Fornecedor> fornecedor;
        public ObservableCollection<Fornecedor> Fornecedor
        {
            get { return fornecedor; }
            set
            {
               
                    fornecedor = value;
                     OnPropertyChanged("Fornecedor");
            }
        }
        public ApiServiceFornecedor servicoFonecedor;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

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
    }
}
