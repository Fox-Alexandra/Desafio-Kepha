using System;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int [3];

            int soma = 0;
            foreach (var item in valor)
            {
                soma += item;
                if (valor == soma)
                {
                    return false;
                } else {
                    return true;
                }
            }
        }
    }
}
