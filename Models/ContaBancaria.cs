namespace TDE04.Models
{
    public class ContaBancaria
    {
        public ContaBancaria()
        {
            NumeroConta = "Desconhecido";
            Titular = "Desconhecido";
            Saldo = 0; 
        }
        public ContaBancaria(string numeroConta, string titular, decimal saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }
        
        public string NumeroConta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
    }
}