using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDE04.Models
{
    public class Aluno
    {
        // Construtores
        public Aluno()
        {
            Nome = "Não informado";
            Idade = 0;
        }
        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Propriedades
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Exibir aluno
        public void ExibirAluno()
        {
            Console.WriteLine($"Nome do aluno: {Nome} e idade: {Idade}");
        }
    }
}
