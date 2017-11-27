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
                 Codigo  = "2154780",
                 valor = 3500.00
            });


            ListSevico.Add(new Servico()
            {
                Nome = "Artigos de Decoração: Molduras",
                Codigo = "2154780",
                valor = 900.00,
            });

            ListSevico.Add(new Servico()
            {
                Nome = "Advocacia Ambiental",
                Codigo = "2154780",
                valor = 5.000

            });

            ListSevico.Add(new Servico()
            {
                Nome = "Aquecedores de Água",
                Codigo = "2154780",

            });

            ListSevico.Add(new Servico()
            {
                Nome = "Gerador energia para comércio e serviços",
                Codigo = "2154780",
                valor = 10.000
            });

            ListSevico.Add(new Servico()
            {
                Nome = "Alarmes de Segurança",
                Codigo = "2154780",
                valor = 1.500
            });

            return ListSevico;
        }
    }
}
