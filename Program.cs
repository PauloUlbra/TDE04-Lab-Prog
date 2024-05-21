using TDE04.Models;
/*

Exercício 1 e 2
Produto produto1 = new Produto();
produto1.ExibirInfo();

Produto produto2 = new Produto("Banana", 5.2f);
produto2.ExibirInfo();

*/

/* 

Exercício 3
Calculadora calculadora = new Calculadora();
Console.WriteLine(calculadora.Soma(1, 2));
Console.WriteLine(calculadora.Soma(1, 2, 3));
Console.WriteLine(calculadora.Soma(1, 2, 3, 4));

*/

/*

Exercício 4
Aluno aluno1 = new Aluno();
aluno1.ExibirAluno();

Aluno aluno2 = new Aluno("Paulo", 21);
aluno2.ExibirAluno();

*/

/* 

Exercício 5
Funcionario funcionario1 = new Funcionario();
Console.WriteLine($"Funcionario: {funcionario1.Nome}, cargo: {funcionario1.Cargo}, salário {funcionario1.Salario:C}");

Funcionario funcionario2 = new Funcionario("Caetano Machado", "Gerente de RH", 3000);
Console.WriteLine($"Funcionario: {funcionario2.Nome}, cargo: {funcionario2.Cargo}, salário {funcionario2.Salario:C}");

*/

/*

Exercício 6
Retangulo exemplo = new Retangulo();
exemplo.CalcularArea();
exemplo.CalcularArea(7, 7);

*/

/*

Exercício 7
Livro livro1 = new Livro();
livro1.ExibirInfo();

Livro livro2 = new Livro("Memórias Póstumas de Brás Cubas", "Machado de Assis", 1881);
livro2.ExibirInfo();

*/

/*

Exercício 8 
ContaBancaria conta1 = new ContaBancaria();
conta1.NumeroConta = "01";
conta1.Titular = "Paulo Roberto";
conta1.Saldo = 1300;

Console.WriteLine($"Conta de número: {conta1.NumeroConta}, titular: {conta1.Titular}. Saldo disponível: {conta1.Saldo:C}");

ContaBancaria conta2 = new ContaBancaria();
Console.WriteLine($"Conta de número: {conta2.NumeroConta}, titular: {conta2.Titular}. Saldo disponível: {conta2.Saldo:C}");

ContaBancaria conta3 = new ContaBancaria("03", "Luan Lippert", 8000);
Console.WriteLine($"Conta de número: {conta1.NumeroConta}, titular: {conta1.Titular}. Saldo disponível: {conta1.Saldo:C}");

*/

/*

Exercício 9
Veiculos carro = new Veiculos();
carro.Infos();

Veiculos moto = new Veiculos("Honda", "Biz", 2020);
moto.Infos();

*/

Conversor toInt = new Conversor();
System.Console.WriteLine(toInt.ConverterDois(4.8));
System.Console.WriteLine(toInt.ConverterDois(4.8).GetType());

Conversor toDouble = new Conversor();
System.Console.WriteLine(toDouble.Converter(6));
System.Console.WriteLine(toDouble.Converter(6).GetType());

Conversor strToInt = new Conversor();
System.Console.WriteLine(strToInt.Converter("10"));
System.Console.WriteLine(strToInt.Converter("10").GetType());

Conversor strToDouble = new Conversor();
System.Console.WriteLine(strToDouble.ConverterDois("54"));
System.Console.WriteLine(strToDouble.ConverterDois("54").GetType());