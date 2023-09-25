using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_SistemaBiblioteca
{
    class Livro
    {
        //atributos
        public string titulo;
        public string autor;
        public bool disponivel;

        //métodos
        public void Emprestar()
        {
            if (disponivel)
            {
                disponivel = false;
                Console.WriteLine("Livro emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine("Livro indisponível para empréstimo.");
            }
        }

        public void Devolver()
        {
            if (!disponivel)
            {
                disponivel = true;
                Console.WriteLine("Livro devolvido com sucesso.");
            }
            else
            {
                Console.WriteLine("Este livro não foi emprestado.");
            }
        }

        public void MostrarInformacoes()
        {
            string disp;
            if (disponivel)
            {
                disp = "Sim";
            }
            else
            {
                disp = "Não";
            }
            Console.WriteLine($"Título: {titulo}\nAutor: {autor}\nDisponível: {disp}");
        }
    }
}
