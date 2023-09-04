namespace ExercicioBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new();
            Livro livro = new("Dom Casmurro", "Machado de Assis", 1889, 350);
            Livro livro2 = new("Dom Casmurro2", "Machado de Assis", 1889, 350);
            MidiaDigital midiaDigi = new("Midia", "Seila", 2006, 340);
            Revista revista = new("Marie Claire", "numsei", 2020, 120);

            biblioteca.AdicionarItem(livro);
            biblioteca.AdicionarItem(livro);

            biblioteca.AdicionarItem(livro2);
            biblioteca.AdicionarItem(midiaDigi);
            biblioteca.AdicionarItem(revista);

            Console.WriteLine("Biblioteca antes de empréstimos:");
            biblioteca.ListarItems();

            biblioteca.Emprestar(livro);
            biblioteca.Emprestar(midiaDigi);
            biblioteca.Emprestar(revista);

            Console.WriteLine("Biblioteca depois de empréstimos:");

            biblioteca.ListarItems();
            biblioteca.Devolver(livro, DateTime.Now);
            biblioteca.Devolver(midiaDigi, DateTime.Now);
        }
    }
}