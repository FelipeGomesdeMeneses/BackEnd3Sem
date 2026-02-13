namespace Exercicio05
{
    public class Pessoa
    {
        public string nome;
        public int idade = 1;


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