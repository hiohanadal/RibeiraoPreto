namespace Estágio_Ribeirão_Preto.Features
{
    internal class Soma
    {
        //soma
        internal void FindSoma()
        {
            var soma = 0;
            var k = 0;
            int i = 13;

            while (k < i)
            {

                k += 1;

                soma += k;

            }

            Console.WriteLine("A soma é " + soma);
        }
    }
}
