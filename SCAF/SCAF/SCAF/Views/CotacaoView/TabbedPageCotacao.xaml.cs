using SCAF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCAF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageCotacao : TabbedPage
    {
        private SolicitacaoCompraViewModel SolicitacaoCompraViewModel;
        private FormaPagamentoViewModel FormaPagamentoViewModel;
        public TabbedPageCotacao ()
        {
            InitializeComponent();
            SolicitacaoCompraViewModel = new SolicitacaoCompraViewModel();
            ScPicker.ItemsSource = SolicitacaoCompraViewModel.ScList();

            FormaPagamentoViewModel = new FormaPagamentoViewModel();
            FomaPgtoPicker.ItemsSource = FormaPagamentoViewModel.ListFormaPagamento();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void DetalheCotacao(object sender, EventArgs e)
        {

        }

        private void IncluirCotação(object sender, EventArgs e)
        {

        }

        private void ExibirFormularioTipoCotacao(object sender, EventArgs e)
        {
            var tipoCotacao = ScPicker.Items[ScPicker.SelectedIndex];
            if (tipoCotacao.Contains("Serviço"))
            {
                ExibirFormCotacaoProduto(false);
                ExibirFormCotacaoServico(true);
            }
            else
            {
                ExibirFormCotacaoServico(false);
                ExibirFormCotacaoProduto(true);
            }

            
        }

        private void ExibirFormCotacaoServico(Boolean valor)
        {
            FormCotacaoServico.IsVisible = valor;
        }

        private void ExibirFormCotacaoProduto(Boolean valor)
        {
            FormCotacaoProduto.IsVisible = valor;
        }
    }
}