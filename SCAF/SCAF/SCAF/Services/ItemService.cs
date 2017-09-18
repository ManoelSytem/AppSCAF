using SCAF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SCAF.Model
{
    public class ItemService
    {
        private static ObservableCollection<MasterPageItem> menuLista { get; set; }

        
        public static ObservableCollection<MasterPageItem> GetMenuItens()
        {
            menuLista = new ObservableCollection<MasterPageItem>();
            // Criando as paginas para navegação
            // Definimos o titulo para o item
            // o icone do lado esquerdo e a pagina que vamos abrir
            var HomeView = new MasterPageItem() { Title = "Inicio", Icon= ImageSource.FromResource("SCAF.Resource.home_icon.png"), TargetType = typeof(HomePage) };
            var SolicitacaoCompraView = new MasterPageItem() { Title = "Solicitação de Compra", Icon = ImageSource.FromResource("SCAF.Resource.sc_icon.png"), TargetType = typeof(SolicitacaoCompraPage) };
            // Adicionando items no menuLista
            menuLista.Add(HomeView);
            menuLista.Add(SolicitacaoCompraView);
            //retorna a lista de itens 
            return menuLista;
        }
    }
}
