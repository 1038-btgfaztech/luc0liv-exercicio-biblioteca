using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    internal class Biblioteca
    {
        public List<ItemBiblioteca> Items = new();

        public void AdicionarItem(ItemBiblioteca item)
        {
            if (Items.Contains(item)) {
                Console.WriteLine("Item já existe na Biblioteca");
            } else
            {
              Items.Add(item);
            }
        }

        public void ListarItems()
        {
            Console.WriteLine("Itens na biblioteca:");
            Console.WriteLine();

            Items.ForEach(item =>
            {
                Console.WriteLine($"Titulo: {item.Titulo}");
                Console.WriteLine($"Autor: {item.Autor}");
                Console.WriteLine($"Ano de publicação: {item.AnoDePublicacao}");
                Console.WriteLine($"Número de Páginas: {item.NumeroDePaginas}");
                Console.WriteLine("---------------------------------------------");
            });
        }

        public void Emprestar(ItemBiblioteca item)
        {
            if (Items.Contains(item) && item is IPodeSerEmprestado itemEmprestimo)
            {
                itemEmprestimo.Emprestar();
                Items.Remove(item);
            }
            else
            {
                Console.WriteLine("Este item não existe ou não pode ser emprestado");
            }
        }

        public void Devolver(ItemBiblioteca item, DateTime devolucao)
        {
            if (item is IPodeSerEmprestado itemDevolucao) 
            {
                itemDevolucao.Devolver(devolucao);
                Items.Add(item);
            }
            else
            {
                Console.WriteLine("O item não pode ser devolvido");
            }
        }
    }
}
