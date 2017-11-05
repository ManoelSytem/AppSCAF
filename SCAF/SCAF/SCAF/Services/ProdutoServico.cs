﻿using SCAF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAF.Services
{
    public class ProdutoServico
    {
        private static ObservableCollection<Produto> ListProduto { get; set; }


        public ProdutoServico()
        {

        }

        public ObservableCollection<Produto> ListaProduto()
        {
            ListProduto = new ObservableCollection<Produto>();

            ListProduto.Add(new Produto()
            {
                Codigo =  1,
                categoria = "Construção e Reforma",
                SubCategoria = "Tubos e Conexões",
                Nome = "Tubos VD 12 mm 9,5",
            });



            ListProduto.Add(new Produto()
            {
                Codigo = 2,
                categoria = "Alimentos e Bebidas",
                SubCategoria = "Alimentos Industrializados",
                Nome = "Café Em Pó Tradicional A Vácuo C/250gr Pila"
            });

            ListProduto.Add(new Produto()
            {
                Codigo = 3,
                categoria = "Alimentos e Bebidas",
                SubCategoria = "Alimentos Industrializados",
                Nome = "Açúcar União Refinado Pacote 1 kg"
            });

            ListProduto.Add(new Produto()
            {
                Codigo = 4,
                categoria = "Alimentos e Bebidas",
                SubCategoria = "Alimentos Industrializados",
                Nome = "Arroz Tio João"
            });

            ListProduto.Add(new Produto()
            {
                Codigo = 5,
                categoria = "Componentes Eletrônicos",
                SubCategoria = "Fios E Cabos Elétricos",
                Nome = "Fios E Cabos Elétricos"
            });

            ListProduto.Add(new Produto()
            {
                Codigo = 6,
                categoria = "Papelarias e Livrarias",
                SubCategoria = "Papelarias e Livrarias",
                Nome = "Papelarias e Livrarias"
            });

            ListProduto.Add(new Produto()
            {
                Codigo = 8,
                categoria = "Automação",
                SubCategoria = "Automação",
                Nome = "Automação"
            });

            ListProduto.Add(new Produto()
            {
                Codigo = 9,
                categoria = "Eletrodomésticos",
                SubCategoria = "Eletrodomésticos",
                Nome = "Eletrodomésticos"
            });
            return ListProduto;
        }
           
        }
    }