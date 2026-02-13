using Exercicio05;
Console.Clear();

Funcionario pessoa1 = new Funcionario();

Console.WriteLine("Digite seu nome:");
pessoa1.nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
pessoa1.idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite seu salário:");
pessoa1.salario = float.Parse(Console.ReadLine());

pessoa1.ExibirDados();
Console.WriteLine($"O salário do funcionario é: {pessoa1.salario}R$");
