using System;
using System.Collections.Generic;
using System.Text;

namespace SA2
{
    class Receitas
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Ingredientes { get; set; }
        public int Dificuldade { get; set; }
        public int Duracao { get; set; }
        public double Preco { get; set; }

        public Receitas(string nome, string categoria, string ingredientes, int dificuldade, int duracao, double peco)
        {
            Nome = nome;
            Categoria = categoria;
            Ingredientes = ingredientes;
            Dificuldade = dificuldade;
            Duracao = duracao;
            Preco = Preco;
        }

        
        public override string ToString()
        {
            return "Nome: " + Nome
               + "Categoria: " + Categoria
                + "Ingredientes: " + Ingredientes
                + "Dificuldade: " + Dificuldade
                + "Duracação: " + Duracao
                + "Preço" + Preco;
        }
    }
}

