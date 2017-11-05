using SCAF.Model;
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
        private ObservableCollection<CotacaoProduto> cotacaoProduto;
        public ObservableCollection<CotacaoProduto> CotacaoProduto
        {
            get { return cotacaoProduto; }
            set
            {

                cotacaoProduto = value;
                Notificar();
            }
        }

        private ObservableCollection<CotacaoServico> cotacaoServico;
        public ObservableCollection<CotacaoServico> CotacaoServico
        {
            get { return cotacaoServico; }
            set
            {
                cotacaoServico = value;
                Notificar();
            }
        }




    }
}
