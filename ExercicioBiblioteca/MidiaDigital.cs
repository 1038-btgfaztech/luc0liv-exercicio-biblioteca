using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    internal class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {
        public MidiaDigital(string titulo, string autor, int anoDePublicacao, int numeroDePaginas)
        {
            Titulo = titulo;
            Autor = autor;
            AnoDePublicacao = anoDePublicacao;
            NumeroDePaginas = numeroDePaginas;
        }

        public void Emprestar()
        {
            Console.WriteLine($"Mídia digital {Titulo} emprestada na data {DateTime.Now.ToString("dd/MM/yyyy")}");
        }

        public void Devolver(DateTime devolucao)
        {
            Console.WriteLine($"Mídia Digital {Titulo} devolvida na data {devolucao.ToString("dd/MM/yyyy")}");
        }
    }
}