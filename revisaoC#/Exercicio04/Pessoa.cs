namespace Exercicio04
{
    public class Pessoa
    {
        public string nome;
        public int idade = 1;

        public Pessoa(string Nome, int Idade)
        {
            nome = Nome;
            idade = Idade;
        }

        public void ExibirDados()
        {
            if (idade <= 0)
            {
                Console.WriteLine($"Não é possível ter idade negativa. Idade informada: {idade}");
            }
            else
            {
            Console.WriteLine($"Seu nome é {nome}, e sua idade é {idade}");
            }
            
        }
    }
}