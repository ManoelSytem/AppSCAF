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
                 NomeServico = "Outdoor",
                 Contrato = "2154780",
                 Categoria = "Publicidade e Marketing"

            });


            ListSevico.Add(new Servico()
            {
                NomeServico = "Artigos de Decoração: Molduras",
                Contrato = "2154780",
                Categoria = "Arquitetura e Decoração"

            });

            ListSevico.Add(new Servico()
            {
                NomeServico = "Advocacia Ambiental",
                Contrato = "2154780",
                Categoria = "Advocacia e Investigações"

            });

            ListSevico.Add(new Servico()
            {
                NomeServico = "Aquecedores de Água",
                Contrato = "2154780",
                Categoria = "Construção, Limpeza e Conservação"

            });

            ListSevico.Add(new Servico()
            {
                NomeServico = "Alarmes de Segurança",
                Contrato = "2154780",
                Categoria = "Segurança"

            });

            return ListSevico;
        }
    }
}
