using SCAF.Model;
using SCAF.ViewModels;
using SCAF.Views.CotacaoView;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCAF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageCotacao : TabbedPage
    {
        private Cotacao cotacao;
        private CotacaoProduto novacotacaoProduto;
        private CotacaoServico novacotacaoServico;
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
            FormaPgtoPicker.ItemsSource = FormaPagamentoViewModel.ListFormaPagamento();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as CotacaoViewModel;
            cotacao = e.Item as Cotacao;
            vm.HideOrShowCotacao(cotacao);
        }

        private async void DetalheCotacao(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CotacaoPageDetalhe(cotacao));
        }

        private void IncluirCotação(object sender, EventArgs e)
        {
            
            var tipoCotacao = ScPicker.Items[ScPicker.SelectedIndex];
            if (tipoCotacao.Contains("Serviço"))
            {
                ValidarDadosServico();
                novacotacaoServico = new CotacaoServico();
                novacotacaoServico.Sc = tipoCotacao;
                novacotacaoServico.Observacao = txtObservacao.Text;
                novacotacaoServico.Custo  = Convert.ToDouble(txtCusto.Text);
                novacotacaoServico.Desconto = Convert.ToDouble(txtDesconto.Text);
                novacotacaoServico.DataEmisao = DataLimiteDaOferta.Date;
                novacotacaoServico.Fornecedor = FornecedorPicker.Items[FornecedorPicker.SelectedIndex];
                novacotacaoServico.FormaPagamento = FormaPgtoPicker.Items[FormaPgtoPicker.SelectedIndex];

                novacotacaoServico.Nome = ServicoPicker.Items[ServicoPicker.SelectedIndex];
                novacotacaoServico.NumeroContrato = txtContrato.Text;
                novacotacaoServico.Valor = Convert.ToDouble(txtValorServico.Text);
                novacotacaoServico.DateInicio = DataInicioCotacaoDataPicker.Date;
                novacotacaoServico.DateFim = DataFimCotacaoDataPicker.Date;

                var vm = BindingContext as CotacaoViewModel;
                vm.HideOrShowCotacao(novacotacaoServico);

            }
            else
            {
                ValidarDadosCotacaoProduto();
                novacotacaoProduto = new CotacaoProduto();
                novacotacaoProduto.Sc = tipoCotacao;
                novacotacaoProduto.Observacao = txtObservacao.Text;
                novacotacaoProduto.Custo = Convert.ToDouble(txtCusto.Text);
                novacotacaoProduto.Desconto = Convert.ToDouble(txtDesconto.Text);
                novacotacaoProduto.DataEmisao = DataLimiteDaOferta.Date;
                novacotacaoProduto.Fornecedor = FornecedorPicker.Items[FornecedorPicker.SelectedIndex];
                novacotacaoProduto.FormaPagamento = FormaPgtoPicker.Items[FormaPgtoPicker.SelectedIndex];


                novacotacaoProduto.Nome = ProdutoPicker.Items[FormaPgtoPicker.SelectedIndex];
                //caso produto não exista
                novacotacaoProduto.Nome = txtNovoProduto.Text;
                //
                novacotacaoProduto.QtdProduto =  Convert.ToInt16(txtQuantidade.Text);
                novacotacaoProduto.Valor = Convert.ToDouble(txtValorProd);

                var vm = BindingContext as CotacaoViewModel;
                vm.HideOrShowCotacao(novacotacaoProduto);

            }


        }

        private bool ValidarDadosCotacaoProduto()
        {
            /*
            novacotacaoProduto = new CotacaoProduto();
            novacotacaoProduto.Sc = tipoCotacao;
            novacotacaoProduto.Observacao = txtObservacao.Text;
            novacotacaoProduto.Custo = Convert.ToDouble(txtCusto.Text);
            novacotacaoProduto.Desconto = Convert.ToDouble(txtDesconto.Text);
            novacotacaoProduto.DataEmisao = DataLimiteDaOferta.Date;
            novacotacaoProduto.Fornecedor = FornecedorPicker.Items[FornecedorPicker.SelectedIndex];
            novacotacaoProduto.FormaPagamento = FormaPgtoPicker.Items[FormaPgtoPicker.SelectedIndex];


            novacotacaoProduto.Nome = ProdutoPicker.Items[FormaPgtoPicker.SelectedIndex];
            //caso produto não exista
            novacotacaoProduto.Nome = txtNovoProduto.Text;
            //
            novacotacaoProduto.QtdProduto = Convert.ToInt16(txtQuantidade.Text);
            novacotacaoProduto.Valor = Convert.ToDouble(txtValorProd);
            */
            return true;
        }

        private void ValidarDadosServico()
        {
           /*
            if(txtObservacao.Texte;
            Convert.ToDouble(txtCusto.Text);
            Convert.ToDouble(txtDesconto.Text);
            DataLimiteDaOferta.Date;
            FornecedorPicker.Items[FornecedorPicker.SelectedIndex];
            FormaPgtoPicker.Items[FormaPgtoPicker.SelectedIndex];

            ServicoPicker.Items[ServicoPicker.SelectedIndex];
            txtContrato.Text;
            Convert.ToDouble(txtValorServico.Text);
            DataInicioCotacaoDataPicker.Date;
            DataFimCotacaoDataPicker.Date;
            */
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