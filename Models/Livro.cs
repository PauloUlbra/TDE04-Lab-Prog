namespace TDE04.Models
{
    public class Livro
    {
        public Livro()
        {
            Titulo = "Não informado";
            Autor = "Desconhecido";
            Ano = 0;
        }
        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
        }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }

        public void ExibirInfo()
        {
            Console.WriteLine($"As informações do livro são as seguintes:\nTitulo: {Titulo}\nAutor: {Autor}\nAno: {Ano}");
        }
    }
}