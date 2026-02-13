namespace Exercicio06
{
    public class Pessoa
    {
        public string nome;
        public int idade = 1;

              
        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {nome}");
            
        }
        public void Apresentar(string sobrenome)
        {
            Console.WriteLine($"Olá meu nome é {nome} {sobrenome}");
            
        }
    }
}