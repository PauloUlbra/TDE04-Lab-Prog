namespace TDE04.Models
{
    public class Veiculos
    {
        public Veiculos()
        {
            Marca = "Desconhecido";
            Modelo = "Desconhecido";
            Ano = 0;
        }
        public Veiculos(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public void Infos()
        {
            System.Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
        }
    }
}