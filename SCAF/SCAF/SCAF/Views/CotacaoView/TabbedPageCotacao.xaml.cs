using SCAF.Model;
using SCAF.ViewModels;
using SCAF.Views.CotacaoView;
using System;
using System.Globalization;
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
        private Random randNum;

        public TabbedPageCotacao()
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
            randNum = new Random();
            var tipoCotacao = ScPicker.Items[ScPicker.SelectedIndex];
            if (tipoCotacao.Contains("Serviço"))
            {
                //ValidarDadosCotacao();
                novacotacaoServico = new CotacaoServico();
                novacotacaoServico.Sc = tipoCotacao;
                novacotacaoServico.Observacao = txtObservacao.Text;
                novacotacaoServico.Custo = (Convert.ToDouble(txtValorServico.Text) - Convert.ToDouble(txtDesconto.Text));
                novacotacaoServico.Desconto = Convert.ToDouble(txtDesconto.Text);
                novacotacaoServico.DataEmisao = DataLimiteDaOferta.Date;
                novacotacaoServico.Fornecedor = FornecedorPicker.Items[FornecedorPicker.SelectedIndex];
                novacotacaoServico.FormaPagamento = FormaPgtoPicker.Items[FormaPgtoPicker.SelectedIndex];

                novacotacaoServico.Nome = ServicoPicker.Items[ServicoPicker.SelectedIndex];
                novacotacaoServico.NumeroContrato = txtContrato.Text;
                novacotacaoServico.Valor = Convert.ToDouble(txtValorServico.Text);
                novacotacaoServico.DateInicio = DataInicioCotacaoDataPicker.Date;
                novacotacaoServico.DateFim = DataFimCotacaoDataPicker.Date;
                novacotacaoServico.StatusDaOferta = "Enviada";
                
                novacotacaoServico.Codigo = Convert.ToString(randNum.Next(3000));
                var vm = BindingContext as CotacaoViewModel;
                vm.HideOrShowCotacao(novacotacaoServico);
                DisplayAlert("Messagem", "Cotação Cadastrada com sucesso!", "ok");
                limparComposCotacaoServico();

            }
            else
            {
                //ValidarDadosCotacao();
                novacotacaoProduto = new CotacaoProduto();
                novacotacaoProduto.Sc = tipoCotacao;
                novacotacaoProduto.Observacao = txtObservacao.Text;
                novacotacaoProduto.Custo = (Convert.ToDouble(txtValorServico.Text) - Convert.ToDouble(txtDesconto.Text));
                novacotacaoProduto.Desconto = Convert.ToDouble(txtDesconto.Text);
                novacotacaoProduto.DataEmisao = DataLimiteDaOferta.Date;
                novacotacaoProduto.Fornecedor = FornecedorPicker.Items[FornecedorPicker.SelectedIndex];
                novacotacaoProduto.FormaPagamento = FormaPgtoPicker.Items[FormaPgtoPicker.SelectedIndex];

                novacotacaoProduto.Nome = ProdutoPicker.Items[ProdutoPicker.SelectedIndex];
                //caso produto não exista
                novacotacaoProduto.Nome = txtNovoProduto.Text;
                //
                novacotacaoProduto.QtdProduto = Convert.ToInt16(txtQuantidade.Text);
                novacotacaoProduto.Valor = Convert.ToDouble(txtValorProd.Text);

                novacotacaoProduto.Codigo = Convert.ToString(randNum.Next(3000));
                novacotacaoProduto.StatusDaOferta = "Enviada";
                var vm = BindingContext as CotacaoViewModel;
                vm.HideOrShowCotacao(novacotacaoProduto);
                DisplayAlert("Messagem", "Cotação Cadastrada com sucesso!", "ok");
                limparCamposCotacaoProduto();
            }

           
        }

        private void limparComposCotacaoServico()
        {
            txtObservacao.Text = null;
            txtCusto.Text = "R$ 0.0";
            txtDesconto.Text = null;
           
            txtContrato.Text = null;
            txtValorServico.Text = null;
        }

        private void limparCamposCotacaoProduto()
        {
            txtObservacao.Text = null;
            txtCusto.Text = "R$ 0.0";
            txtDesconto.Text = null;

            txtNovoProduto.Text = null;
            txtQuantidade.Text = null;
            txtValorProd.Text = null;
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
            if (ProdutoPicker.SelectedIndex != -1)
            {
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

        private void AtualizarCusto(object sender, TextChangedEventArgs e)
        {

            var tipoCotacao = ScPicker.Items[ScPicker.SelectedIndex];
            if (tipoCotacao.Contains("Serviço"))
            {

                if (txtDesconto.Text != null && txtDesconto.Text != "" && txtValorServico.Text != null && txtValorServico.Text != "")
                {
                    var custoatualizado = (Convert.ToDouble(txtValorServico.Text) - Convert.ToDouble(txtDesconto.Text));
                    txtCusto.Text = "R$ " + String.Format("{0:N}", custoatualizado);
                }
                else
                {
                    txtCusto.Text = "R$ " + String.Format("{0:N}", 0);
                }
            }
            else
            {
                if (txtDesconto.Text != null && txtDesconto.Text !="" && txtValorProd.Text != null && txtValorProd.Text != "")
                {
                    var custoatualizado =  (Convert.ToDouble(txtValorProd.Text) - Convert.ToDouble(txtDesconto.Text));
                    txtCusto.Text = "R$ " + String.Format("{0:N}", custoatualizado);
                }
                else
                {
                    txtCusto.Text = "R$ "+String.Format("{0:N}", 0);
                }

            }
        }
    }
}
