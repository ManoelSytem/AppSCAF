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
                Status = "Em Andamento",
                DataEmisao = DateTime.Now,
                Solicitante = "Estevão Roma",
                TextColorStatus = "#ffd000",
                Cliente = "Rede Bahia de Televisão",
                Prazo = DateTime.Now.AddDays(10),
                Observacao = "Esta solicitação deve ser atendida em emediato",
                Comprador = "Manoel Neto",
                Departamento = "Compra",
                FormaPagamento = "A vista"
            });

            ListSolicitacaoCompra.Add(new SolicitacaoCompra()
            {
                Status = "Em Cotação",
                DataEmisao = DateTime.Now,
                Solicitante = "Davi Reis",
                Cliente = "Rede Bahia de Televisão",
                TextColorStatus = "#ff7700",
                Prazo = DateTime.Now.AddDays(10),
                Observacao = "Esta solicitação deve ser atendida em emediato",
                Comprador = "Manoel Neto",
                Departamento = "Compra",
                FormaPagamento = "A Prazo"
            });


            return ListSolicitacaoCompra;
        }

    }
}
