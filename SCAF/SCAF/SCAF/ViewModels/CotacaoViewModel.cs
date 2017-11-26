using SCAF.Model;
using SCAF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAF.ViewModels
{
    public sealed class CotacaoViewModel : NotificarBase
    {
        public SolicitacaoCompraService ScServico;
        private ProdutoServico Produtos;
        private RepositorioServico Servicos;
        private Cotacao _oldCotacao;
        public ObservableCollection<FormaPagamento> FormaPagameto { get; set; }
        public ObservableCollection<Cotacao> Cotacao { get; set; }
        public List<string> ListaProdutoServico;
        private static readonly CotacaoViewModel instance = new CotacaoViewModel();
        public static CotacaoViewModel Instance
        {
            get
            {
                return instance;
            }
        }
        public CotacaoViewModel()
        {
            Produtos = new ProdutoServico();
            Servicos = new RepositorioServico();
            ScServico = new SolicitacaoCompraService();

            Cotacao = new ObservableCollection<Cotacao>
            {
                new CotacaoProduto
                {
                   Codigo = "2504",
                   DataEmisao = DateTime.Now,
                   DataFim = DateTime.Now.AddDays(5),
                   Custo = 1500,
                   Desconto = 200,
                   FormaPagamento = "A vista",
                   Observacao ="Cotação com descontato foi a vista, a prazo nem tem desconto.",
                   Produto = Produtos.ListaProduto().ToList().Find(cod => cod.Codigo.Equals(1)),
                   QtdProduto = 150,
                   Sc = ScServico.GetSc().ToList().Find(sc => sc.codigo.Contains("014524")).codigo,
                   StatusDaOferta = "Cotação Realizada",
                },

                new CotacaoServico
                {
                   Codigo = "2605",
                   DataEmisao = DateTime.Now,
                   DataFim = DateTime.Now.AddDays(5),
                   Custo = 3000,
                   Desconto = 500,
                   FormaPagamento = "A vista",
                   Observacao ="Preço cotado a prazo 10% de desconto.",
                   Servico = Servicos.ListaServico().ToList().Find(cod => cod.Codigo.Equals("2154780")),
                   NumeroContrato = 15465,
                   Sc = ScServico.GetSc().ToList().Find(sc => sc.codigo.Contains("054875")).codigo,
                   StatusDaOferta = "Cotação Realizada",
                }
            };

        }

        public List<string> ObterProdutoOuServicoPorFornecedorCategoria(string categoria)
        {
           ListaProdutoServico = new List<string>();
           ListaProdutoServico.Add("Novo");
            var ListProdutos  = Produtos.ListaProduto().Where(l => (l.categoria.ToLower().Contains(categoria.ToLower())));
           var ListServico = Servicos.ListaServico().Where(l => (l.Nome.ToLower().Contains(categoria.ToLower())));

            foreach (var i in ListProdutos)
            {
                ListaProdutoServico.Add("Produto-"+i.categoria+"-"+i.Nome);
            }

            foreach (var i in ListServico)
            {
                ListaProdutoServico.Add("Serviço-"+ i.Nome);
            }

            return ListaProdutoServico;
        }

        public void HideOrShowCotacao(Cotacao cotacao)
        {
            if (_oldCotacao == cotacao)
            {
                cotacao.IsVisible = !cotacao.IsVisible;
                UpdateCotacao(cotacao);
            }
            else
            {
                if (_oldCotacao != null)
                {
                    _oldCotacao.IsVisible = false;
                    UpdateCotacao(cotacao);
                }
                cotacao.IsVisible = true;
                UpdateCotacao(cotacao);
            }

            _oldCotacao = cotacao;
        }

        private void UpdateCotacao(Cotacao cotacao)
        {
            var Index = Cotacao.IndexOf(cotacao);
            if (Index != -1)
            {
                Cotacao.Remove(cotacao);
                Cotacao.Insert(Index, cotacao);
            }
            else
            {
                var caunt = Cotacao.Count;
                cotacao.IsVisible = false;
                Cotacao.Insert(caunt, cotacao);
            }
        }
    }
}
