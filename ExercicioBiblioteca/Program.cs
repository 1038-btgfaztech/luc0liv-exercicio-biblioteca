namespace ExercicioBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new();
            Livro livro = new("Dom Casmurro", "Machado de Assis", 1899, 350);
            Livro livro2 = new("O Conto da Aia", "Margaret Atwood", 1985, 350);
            MidiaDigital midiaDigi = new("Jogos Vorazes", "Suzanne Collins", 2008, 400);
            Revista revista = new("Turma da Mônica", "Mauricio de Sousa", 2020, 120);

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