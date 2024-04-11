namespace Estágio_Ribeirão_Preto.Features
{
    internal class Fibonacci
    {
        internal void FibonacciValidation() 
        {
            Console.Write("Informe o nº: ");

            var input = Console.ReadLine();

            if (!int.TryParse(input, out var number))
            {
                Console.Write("Informe um número válido");
                return;
            }

            int i = 0;
            int j = 1;

            while (j < number && i < number)
            {

                i = i + j;
                j = i + j;

            }

            if (j == number || i == number)
            {
                Console.WriteLine("O número informado pertence à sequência Fibonacci");
                return;
            }

            Console.WriteLine("O número informado não pertence à sequência Fibonacci");
        }
    }
}
