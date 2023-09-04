using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    internal abstract class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoDePublicacao { get; set; }
        public int NumeroDePaginas { get; set; }
    }
}
