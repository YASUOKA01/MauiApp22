﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp22
{
    internal class Produto
    {
         public double Preco { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }

        public static List<Produto> lista 
        {
            get
            {
                List<Produto> lista = new List<Produto>();
                lista.Add(new Produto() { Nome = "Buzina", Preco = 300, Categoria = "Acessórios" });
                lista.Add(new Produto() { Nome = "Mouse", Preco = 30, Categoria = "Informatica" });
                lista.Add(new Produto() { Nome = "Paçoca", Preco = 3, Categoria = "Alimento" });
                lista.Add(new Produto() { Nome = "NoteBook", Preco = 3000, Categoria = "Informatica" });
                lista.Add(new Produto() { Nome = "Moto", Preco = 30000, Categoria = "automovel" });

                return lista;
            }
        }

    }
}
