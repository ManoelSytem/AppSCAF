using SCAF.Model;
using System;
using System.Collections.ObjectModel;


namespace SCAF.Services
{
    public class SolicitacaoCompraService
    {
        private static ObservableCollection<SolicitacaoCompra> ListSolicitacaoCompra { get; set; }

        public static ObservableCollection<SolicitacaoCompra> GetSc()
        {
            ListSolicitacaoCompra = new ObservableCollection<SolicitacaoCompra>();

            ListSolicitacaoCompra.Add(new SolicitacaoCompra() {
                Status = "Em Andamento",
                DataEmisao = DateTime.Now,
                Cliente = "Casas Bahia",
                Prazo = DateTime.Now,
                Observacao = "Esta solicitação deve ser atendida em emediato",
                Comprador = "Manoel Neto",
                Departamento = "Compra",
                FormaPagamento = "A vista"
            });
            

            return ListSolicitacaoCompra;
        }

    }
}
