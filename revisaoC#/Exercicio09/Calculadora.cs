namespace Exercicio09
{
    public class Calculadora
    {
        public static void Somar(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"A soma de {a} e {b} é: {resultado}");
        }
        public static void Multiplicar(int a, int b)
        {
            int resultado = a * b;
            Console.WriteLine($"A multiplicação de {a} e {b} é: {resultado}");
        }
    }
}