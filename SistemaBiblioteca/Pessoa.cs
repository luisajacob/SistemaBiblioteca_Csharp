using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_SistemaBiblioteca
{
    class Pessoa
    {
        //atributos
        public string Nome { get; set; }
        public double RA { get; set; }
        public List<Livro> Emprestados { get; set; }

        //métodos
        public Pessoa (string nome, double ra)
        {
            this.Nome = nome;
            this.RA = ra;
        }

        public void Emprestimos (List<Livro> emprestado)
        {
            Emprestados = emprestado;
        }
        
        public void MostrarEmprestimos()
        {
            if(Emprestados == null)
            {
                Console.WriteLine("Você não possue empréstimos");
                Console.WriteLine("Pressione Enter para continuar");
                Console.ReadLine();
            }
            else
            {
                foreach (Livro livros in Emprestados)
                {
                    Console.WriteLine(livros.titulo);
                }
            }
        }
    }
}
