using SCAF.Model;
using SCAF.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace SCAF.ViewModels
{
       
    public sealed class FornecedorViewModel : NotificarBase
    {

        private static readonly FornecedorViewModel instance = new FornecedorViewModel();
        public static FornecedorViewModel Instance
        {
            get
            {
                return instance;
            }
        }

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
               },

                new Fornecedor
               {
                NomeFantasia = "disalli",
                Cnpj = "41.429.286/0001-02",
                Categoria = "Alimentos"
               },

                 new Fornecedor
               {
                NomeFantasia = "Agtal",
                Cnpj = "98.596.467/0001-40",
                Categoria = "Alimentos"
               },

               new Fornecedor
               {
                NomeFantasia = "Fibromax",
                Cnpj = "28.180.381/0001-57",
                Categoria = "Indústria e Comércio"
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

        public void DeleteFornecedor(Fornecedor fornecedor)
        {
            Fornecedor.Remove(fornecedor);
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


        public List<string> ListFornecedor()
        {
            var ListForn = new List<string>();
            foreach (var forn in fornecedor)
            {
                ListForn.Add(forn.NomeFantasia + "-" + forn.Categoria);
            }

            return ListForn;
        }
    }
}
