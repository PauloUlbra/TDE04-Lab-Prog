namespace TDE04.Models
{
    public class Funcionario
    {
        public Funcionario()
        {
            Nome = "Desconhecido";
            Cargo = "Não informado";
            Salario = 0d;
        }
        public Funcionario(string nome, string cargo, double salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }
        
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
    }
}

