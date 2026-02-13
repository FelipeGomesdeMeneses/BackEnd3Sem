using Exercicio02;
Console.Clear();

Pessoa pessoa1 = new Pessoa();
Console.WriteLine("Digite seu nome:");
pessoa1.nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
pessoa1.idade = int.Parse(Console.ReadLine());

pessoa1.ExibirDados();