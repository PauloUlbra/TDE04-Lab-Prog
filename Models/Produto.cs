using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDE04.Models
{
    // Criação da Classe Produto
    public class Produto 
    {
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto()
        {
            Nome = "Desconhecido";
            Preco = 0.0f;
        }
        public Produto(string nome, float preco)
        {
            Nome = nome;
            Preco = preco;
        }

        // Sobrecarga do método ExibirInfo
        public void ExibirInfo(bool exibirPreco = true) 
        {
            Console.Write($"O nome do produto é {Nome}");
            if (exibirPreco)
            {
                Console.Write($" e seu preço é {Preco}\n");
            }
        }
    }
}