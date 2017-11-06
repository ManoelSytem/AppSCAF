using SCAF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAF.Services
{
    public class RepositorioServico
    {
        private static ObservableCollection<Servico> ListSevico { get; set; }


        public RepositorioServico()
        {

        }

        public ObservableCollection<Servico> ListaServico()
        {
            ListSevico = new ObservableCollection<Servico>();

            ListSevico.Add(new Servico()
            {
                 Nome = "Outdoor",
                 Codigo  = "2154780"
            });


            ListSevico.Add(new Servico()
            {
                Nome = "Artigos de Decoração: Molduras",
                Codigo = "2154780",

            });

            ListSevico.Add(new Servico()
            {
                Nome = "Advocacia Ambiental",
                Codigo = "2154780",

            });

            ListSevico.Add(new Servico()
            {
                Nome = "Aquecedores de Água",
                Codigo = "2154780",

            });

            ListSevico.Add(new Servico()
            {
                Nome = "Alarmes de Segurança",
                Codigo = "2154780",

            });

            return ListSevico;
        }
    }
}
