namespace TDE04.Models
{
    public class Retangulo
    {
        public float Altura { get; set; }
        public float Largura { get; set; }

        public void CalcularArea()
        {
            Console.WriteLine("Digite a altura do retângulo:");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Agora, digite a largura:");
            float largura = float.Parse(Console.ReadLine());

            float resultado = altura * largura;
            Console.WriteLine($"A área do retângulo é: {resultado}");
        }

        public void CalcularArea(float altura, float largura)
        {
            Altura = altura;
            Largura = largura;
            Console.WriteLine($"A área do retângulo é: {altura * largura}");
        }
    }
}
