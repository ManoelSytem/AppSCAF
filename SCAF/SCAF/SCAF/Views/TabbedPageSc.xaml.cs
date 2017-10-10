using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCAF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageSc : TabbedPage
    {
        public TabbedPageSc ()
        {
            InitializeComponent();
        }
    }
}