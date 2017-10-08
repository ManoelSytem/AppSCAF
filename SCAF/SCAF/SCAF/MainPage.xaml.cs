using SCAF.Model;
using SCAF.ViewModels;
using SCAF.Views;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SCAF
{
    public partial class MainPage : MasterDetailPage
    {
        private ObservableCollection<MasterPageItem> _menuLista;

        public MainPage()
        {
            InitializeComponent();
            _menuLista = ItemService.GetMenuItens();
            navigationDrawerList.ItemsSource = _menuLista;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            //obtem o tipo de objeto 
            Type pagina = item.TargetType;

            //abre a pagina correspondente ao item selecionado
            //Cria uma instância do tipo especificado usando o construtor
            //que melhor se adequa ao parametro informado
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            IsPresented = false;
        }
    }
}
