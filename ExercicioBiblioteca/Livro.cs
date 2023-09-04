using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    internal class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public DateTime DataDeEmprestimo { get; set; }
        public DateTime DataDeDevolucao { get; set; }
        public Livro(string titulo, string autor, int anoDePublicacao, int numeroDePaginas)
        {
            Titulo = titulo;
            Autor = autor;
            AnoDePublicacao = anoDePublicacao;
            NumeroDePaginas = numeroDePaginas;
        }

        public void Emprestar()
        {
            DataDeEmprestimo = DateTime.Now;
            DataDeDevolucao = new DateTime(DataDeEmprestimo.Year, DataDeEmprestimo.Month, DataDeEmprestimo.Day + 7);
            Console.WriteLine($"Empréstimo do livro {Titulo} realizado no dia {DataDeEmprestimo.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Deverá ser devolvido na data: {DataDeDevolucao.ToString("dd/MM/yyyy")}");
        }

        public void Devolver(DateTime devolucao)
        {
            if (devolucao > DataDeDevolucao)
            {
                Console.WriteLine($"Entrega do livro {Titulo} com atraso");
            } else
            {
                Console.WriteLine($"Devolução do livro {Titulo} realizada");
            }

        }
    }
}
