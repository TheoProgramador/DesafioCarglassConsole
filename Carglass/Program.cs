
namespace Carglass
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            var NumberDigited = Console.ReadLine();
            if (int.TryParse(NumberDigited, out int inputNumber) && inputNumber > 0)
            {
                var divisors = GetDivisors(inputNumber);
                var primeDivisors = GetPrimeDivisors(divisors);

                Console.WriteLine($"Número de Entrada: {inputNumber}");
                Console.WriteLine("Números divisores: " + string.Join(" ", divisors));
                Console.WriteLine("Divisores Primos: " + string.Join(" ", primeDivisors));
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro positivo.");
            }
        }

        /*
         Método responsavel por retornar os divisores normais de um numero
         */
        private static List<int> GetDivisors(int number)
        {
            var divisors = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors;
        }

        /*
         Método responsavel por abstrair uma lista de numeros primos vindo de uma lista de numeros
         */
        private static List<int> GetPrimeDivisors(List<int> divisors)
        {
            var primes = new List<int>();
            foreach (var divisor in divisors)
            {
                if (IsPrime(divisor))
                {
                    primes.Add(divisor);
                }
            }
            return primes;
        }

        /*
         Método auxiliar para validar se um numero passado é primo
         */
        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
