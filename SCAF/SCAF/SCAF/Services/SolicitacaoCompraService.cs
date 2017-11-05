using SCAF.Model;
using System;
using System.Collections.ObjectModel;


namespace SCAF.Services
{
    public class SolicitacaoCompraService
    {
        private static ObservableCollection<SolicitacaoCompra> ListSolicitacaoCompra { get; set; }


        public SolicitacaoCompraService()
        {

        }

        public  ObservableCollection<SolicitacaoCompra> GetSc()
        {
            ListSolicitacaoCompra = new ObservableCollection<SolicitacaoCompra>();

            ListSolicitacaoCompra.Add(new SolicitacaoCompra() {
                codigo = "014524",
                Status = "Em Andamento",
                DataEmisao = DateTime.Now,
                Solicitante = "Estevão Roma",
                TextColorStatus = "#ffd000",
                Cliente = "Rede Bahia de Televisão",
                Prazo = DateTime.Now.AddDays(10),
                Observacao = "Solicito a cotação de Tubos VD 12 mm 9,5",
                Comprador = "Manoel Neto",
                Departamento = "Telecomunicações",
                FormaPagamento = "A vista",
                Tipo = "Produto"
               
            });

            ListSolicitacaoCompra.Add(new SolicitacaoCompra()
            {
                codigo = "027485",
                Status = "Em Cotação",
                DataEmisao = DateTime.Now,
                Solicitante = "Davi Reis",
                Cliente = "Rede Bahia de Televisão",
                TextColorStatus = "#ff7700",
                Prazo = DateTime.Now.AddDays(10),
                Observacao = "Café Em Pó Tradicional A Vácuo C/250gr Pilao. Quantidade 150. Solicitação para reposição do estoque",
                Comprador = "Manoel Neto",
                Departamento = "Compra",
                FormaPagamento = "A Prazo",
                Tipo = "Produto"
            });

            ListSolicitacaoCompra.Add(new SolicitacaoCompra()
            {
                codigo = "054875",
                Status = "Em Andamento",
                DataEmisao = DateTime.Now,
                Solicitante = "Larrisa Silva",
                Cliente = "Globo FM",
                TextColorStatus = "#ffd000",
                Prazo = DateTime.Now.AddDays(10),
                Observacao = "Solicito realizar cotação de serviço de outdoor. publicidade de 10 dias, sem Design. Cotação até 3 fornecedores.",
                Comprador = "Manoel Neto",
                Departamento = "Publicidade",
                FormaPagamento = "A Prazo",
                Tipo = "Serviço"
            });


            return ListSolicitacaoCompra;
        }

    }
}
