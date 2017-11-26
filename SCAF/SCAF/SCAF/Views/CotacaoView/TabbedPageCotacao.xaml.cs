using SCAF.Model;
using SCAF.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCAF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageCotacao : TabbedPage
    {
        private Cotacao cotacao;
        private SolicitacaoCompraViewModel SolicitacaoCompraViewModel;
        private FormaPagamentoViewModel FormaPagamentoViewModel;
        
        public TabbedPageCotacao ()
        {
            InitializeComponent();
            SolicitacaoCompraViewModel = new SolicitacaoCompraViewModel();
            ScPicker.ItemsSource = SolicitacaoCompraViewModel.ScList();
            FornecedorViewModel FornecedorViewModel = FornecedorViewModel.Instance;
            FornecedorPicker.ItemsSource = FornecedorViewModel.ListFornecedor();
            FormaPagamentoViewModel = new FormaPagamentoViewModel();
            FomaPgtoPicker.ItemsSource = FormaPagamentoViewModel.ListFormaPagamento();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as CotacaoViewModel;
            cotacao = e.Item as Cotacao;
            vm.HideOrShowCotacao(cotacao);
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

        private void ObterProdutoOuServicoPorFornecedor(object sender, EventArgs e)
        {

            var CategoriaFornecedor = FornecedorPicker.Items[FornecedorPicker.SelectedIndex];
            int indice = CategoriaFornecedor.IndexOf("-");
            CotacaoViewModel CotacaoViewModel = CotacaoViewModel.Instance;
            
            var returnBusca = CotacaoViewModel.ObterProdutoOuServicoPorFornecedorCategoria(CategoriaFornecedor.Substring(indice + 1));
                
                ServicoPicker.ItemsSource = returnBusca;
                ProdutoPicker.ItemsSource = returnBusca;
                
        }

        private void ProdutoPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ProdutoPicker.SelectedIndex != -1) { 
            var selecao = ProdutoPicker.Items[ProdutoPicker.SelectedIndex];

            if (selecao.Contains("Novo"))
            {
              txtNovoProduto.IsVisible = true;
            }
            else
            {
              txtNovoProduto.IsVisible = false;
            }

            }
        }

        private void EditarCotação(object sender, EventArgs e)
        {

        }

        private void DeletaCotação(object sender, EventArgs e)
        {

        }
    }
}