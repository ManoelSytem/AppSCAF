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
        public CotacaoPageDetalhe(Cotacao cotacao)
        {
            InitializeComponent();
        }
    }
}