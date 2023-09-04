using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    internal class Revista : ItemBiblioteca
    {
        public Revista(string titulo, string autor, int anoDePublicacao, int numeroDePaginas)
        {
            Titulo = titulo;
            Autor = autor;
            AnoDePublicacao = anoDePublicacao;
            NumeroDePaginas = numeroDePaginas;
        }
    }
}
