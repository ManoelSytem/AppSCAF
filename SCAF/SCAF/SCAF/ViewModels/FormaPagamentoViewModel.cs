using SCAF.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SCAF.ViewModels
{
    public class FormaPagamentoViewModel
    {

        public ObservableCollection<FormaPagamento> formaPagameto { get; set; }

        public FormaPagamentoViewModel()
        {
            formaPagameto = new ObservableCollection<FormaPagamento>
            {
                new FormaPagamento { Codigo = 1, Nome = "A Vista" },
                new FormaPagamento { Codigo = 2, Nome = "A Prazo" },
                new FormaPagamento { Codigo = 3, Nome = "Cartão de Crédito" },
                new FormaPagamento { Codigo = 4, Nome = "Boleto Bancario" },
                new FormaPagamento { Codigo = 6, Nome = "Permuta" },
                new FormaPagamento { Codigo = 7, Nome = "Mensal - Dinheiro" },
                new FormaPagamento { Codigo = 8, Nome = "Anual - Dinheiro" },
                new FormaPagamento { Codigo = 8, Nome = "Cheque" },
            };
        }

        public List<string> ListFormaPagamento()
        {
            var LisPgto = new List<string>();
            foreach (var pgto in formaPagameto)
            {
                LisPgto.Add(pgto.Codigo+"-"+pgto.Nome);
            }

            return LisPgto;
        }
    }
}
