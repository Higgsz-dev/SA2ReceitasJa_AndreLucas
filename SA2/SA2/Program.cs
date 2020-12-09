using System;
using System.Globalization;

namespace SA2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis globais
            int n = 2;
            int escolha;

            string nome;
            string categoria;
            string ingredientes;
            int dificuldade;
            int duracao;
            double preco;

            Receitas[] receitas = new Receitas[n];

            do
            {
                Console.WriteLine("          BEM VINDO AO ");
                Console.WriteLine("           Receita Já!");
                Console.WriteLine("");
                Console.WriteLine("1 - Adicionar receitas");
                Console.WriteLine("2 - Consultar receitas");
                Console.WriteLine("3 - Remover receitas");
                Console.WriteLine("0 - Encerrar o programa");
                Console.Write("Digite a opção desejada: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Digite o nome da receita: ");
                            nome = Console.ReadLine();

                            Console.WriteLine("Digite a categoria desta receita: ");
                            categoria = Console.ReadLine();

                            Console.WriteLine("Digite os ingreidnetes para essa receita: ");
                            ingredientes = Console.ReadLine();

                            Console.WriteLine("Qual a dificuldade onde: ");
                            Console.WriteLine("1 - Bem simples");
                            Console.WriteLine("2 - Moderada");
                            Console.WriteLine("3 - Complicada");
                            Console.WriteLine("Escolha um nível: ");
                            dificuldade = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite em média quantos minutos duram a preparação da receita: ");
                            duracao = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o preço dessa receita: ");
                            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                            receitas[i] = new Receitas(nome, categoria, ingredientes, dificuldade, duracao, preco);
                        }

                        Console.Clear();
                        break;

                    case 2:
                        

                        Console.WriteLine("Catalogo de receitas");
                        Console.WriteLine("Exibir receitas por: ");
                        Console.WriteLine("1 - Dificuldade");
                        Console.WriteLine("2 - Categoria");
                        Console.WriteLine("3 - Duracao");
                        int opcao = int.Parse(Console.ReadLine());

                        //Exibindo por didifucldade
                        if (opcao == 1)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                if (dificuldade[i] > dificuldade[i + 1])
                                {
                                    dificuldade[i] = dificuldade[i + 1];
                                }

                                for (i = 0; i < n; i++)
                                {
                                    Console.WriteLine(receitas[i]);
                                }
                            }
                        }

                        if (opcao == 2)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                if (categoria[i] != categoria[i + 1])
                                {
                                    Console.WriteLine(categoria[i]);
                                }

                                Console.WriteLine("Digite a categoria que deseja ver as receitas: ");
                                string escolhaCategoria = Console.ReadLine();

                                for (i = 0; i < n; i++)
                                {
                                    if (categoria[i] == escolhaCategoria)
                                    {
                                        Console.WriteLine(receitas[i]);
                                    }
                                }
                            }
                        }

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(i + " " + nome[i] + " " + categoria[i]); //Como exibir o nome e categoria
                        }
                        break;

                    case 3:
                        Console.WriteLine("Catalogo de receitas");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(i + " " + nome[i]+ " "+ categoria[i]);
                        }
                        Console.WriteLine("Digite a receita que deseja remover do catalogo: ");
                        int opcao = int.Parse(Console.ReadLine());

                        nome[opcao] = null;

                        break;
                }
            }
            while (escolha != 0);
            
        }
    }
}
