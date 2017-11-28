using SCAF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCAF.Views.CotacaoView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CotacaoPageDetalhe : ContentPage
    {
        private CotacaoProduto cotacaoProd;
        private CotacaoServico cotacaoServico;
        public CotacaoPageDetalhe(Cotacao cotacao)
        {
           
            InitializeComponent();
            lblSolicitacao.Text = cotacao.Sc;
            lblObservacao.Text = cotacao.Observacao;
            lblDesconto.Text = Convert.ToString(cotacao.Desconto);
            lblFornecedor.Text = cotacao.Fornecedor;
            lblfrmPgto.Text = cotacao.FormaPagamento;
            lblDataLimiteOferta.Text = Convert.ToString(cotacao.DataEmisao);

            if (cotacao.Sc.Contains("Serviço"))
            {
                cotacaoServico = cotacao as CotacaoServico;
                stackCotacaoServico.IsVisible = true;
                lblnomeservico.Text = cotacaoServico.Nome;
                lblContrato.Text = cotacaoServico.NumeroContrato;
            }
            else
            {
                cotacaoProd = cotacao as CotacaoProduto;
                stackCotacaoProduto.IsVisible = true;
                lblnomeProduto.Text = cotacaoProd.Nome;
            }
        }
    }
}