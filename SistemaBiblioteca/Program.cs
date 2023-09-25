using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atividade_SistemaBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro[] livro = new Livro[5];

            // Cadastrar livros
            livro[0] = new Livro();
            livro[0].titulo = "Dom Casmurro";
            livro[0].autor = "Machado de Assis";
            livro[0].disponivel= true;

            livro[1] = new Livro();
            livro[1].titulo = "O Pequeno Príncipe";
            livro[1].autor = "Antoine de Saint-Exupéry";
            livro[1].disponivel = true;

            livro[2] = new Livro();
            livro[2].titulo = "O Hobbit";
            livro[2].autor = "T.R.R. Tolkien";
            livro[2].disponivel = true;

            livro[3] = new Livro();
            livro[3].titulo = "A Revolução dos Bichos";
            livro[3].autor = "George Orwell";
            livro[3].disponivel = true;

            livro[4] = new Livro();
            livro[4].titulo = "A menina que roubava livros";
            livro[4].autor = "Markus Zusak";
            livro[4].disponivel = true;

            Console.WriteLine("Bem-vindo(a) à Biblioteca da Faculdade!");
            int escolha;
            
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu RA: ");
            double ra = Convert.ToDouble(Console.ReadLine());
            Pessoa pessoa1 = new Pessoa(nome, ra);
            List<Livro> emprestados = new List<Livro>();
            Thread.Sleep(1000);
            Console.Clear();

            do
            {
                //interagindo com o usuário
                Console.WriteLine($"O que você deseja fazer, {nome}?");
                Console.WriteLine("1 - Pegar um livro emprestado");
                Console.WriteLine("2 - Devolver um livro");
                Console.WriteLine("3 - Mostrar informações de um livro");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("5 - Exibir meus empréstimos");

                escolha = int.Parse(Console.ReadLine());

                Thread.Sleep(1000);
                Console.Clear();

                //escolha para pegar livro emprestado
                if (escolha == 1)
                {
                    Console.WriteLine($"Qual Livro você deseja pegar emprestado, {nome}?");
                    Console.WriteLine("1 - " + livro[0].titulo);
                    Console.WriteLine("2 - " + livro[1].titulo);
                    Console.WriteLine("3 - " + livro[2].titulo);
                    Console.WriteLine("4 - " + livro[3].titulo);
                    Console.WriteLine("5 - " + livro[4].titulo);

                    //escolha para escoher livro
                    int n1 = int.Parse(Console.ReadLine());

                    n1 -= 1;

                    livro[n1].Emprestar();
                    emprestados.Add(livro[n1]);
                    pessoa1.Emprestimos(emprestados);
                }
                else if (escolha == 2)
                {
                    Console.WriteLine($"Qual livro você deseja devolver, {nome}?");
                    Console.WriteLine("1 - " + livro[0].titulo);
                    Console.WriteLine("2 - " + livro[1].titulo);
                    Console.WriteLine("3 - " + livro[2].titulo);
                    Console.WriteLine("4 - " + livro[3].titulo);
                    Console.WriteLine("5 - " + livro[4].titulo);

                    //escolha para devolver o livro
                    int n2 = int.Parse(Console.ReadLine());

                    n2 -= 1;

                    livro[n2].Devolver();
                    emprestados.Remove(livro[n2]);
                    pessoa1.Emprestimos(emprestados);
                }
                else if (escolha == 3)
                {
                    Console.WriteLine($"Qual livro você deseja ver as informações, {nome}?");
                    Console.WriteLine("1 - " + livro[0].titulo);
                    Console.WriteLine("2 - " + livro[1].titulo);
                    Console.WriteLine("3 - " + livro[2].titulo);
                    Console.WriteLine("4 - " + livro[3].titulo);
                    Console.WriteLine("5 - " + livro[4].titulo);

                    //escolha para devolver o livro
                    int n3 = int.Parse(Console.ReadLine());

                    n3 -= 1;

                    livro[n3].MostrarInformacoes();
                }
                else if (escolha == 4)
                {
                    Console.WriteLine("Programa encerrado.");
                    Console.ReadKey();
                }
                else if (escolha == 5)
                {
                    pessoa1.MostrarEmprestimos();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Tente Novamente.");
                }
                Thread.Sleep(1000);
                Console.Clear();

            } while (escolha != 4);
            Console.ReadKey();
        }
    }
}
