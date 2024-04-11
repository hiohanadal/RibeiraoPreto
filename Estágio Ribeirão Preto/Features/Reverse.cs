namespace Estágio_Ribeirão_Preto.Features
{
    internal class Reverse
    {
        // inverter caracteres
        internal void Caracteres(string word) 
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
        }
    }
}
