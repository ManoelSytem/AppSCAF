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
    public class CotacaoViewModel : NotificarBase
    {
        public SolicitacaoCompraService ScServico;
        private ProdutoServico Produtos;
        private RepositorioServico Servicos;

        public ObservableCollection<Cotacao> Cotacao { get; set; }
       
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
                }
            };

        }

    }
}
