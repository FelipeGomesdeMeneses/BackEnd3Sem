using Exercicio04;
Console.Clear();

Pessoa pessoa1 = new Pessoa(Nome: "Felipe", Idade: 17);
Console.WriteLine($"Dados iniciais: {pessoa1.nome}, {pessoa1.idade} anos.");



Console.WriteLine("Digite seu nome:");
pessoa1.nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
pessoa1.idade = int.Parse(Console.ReadLine());

pessoa1.ExibirDados();