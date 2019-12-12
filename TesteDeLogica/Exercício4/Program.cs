using System;

namespace Exercício4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] array = new int[8];
            int[] contadorB = new int[8];

            int aux = 0;

            int contador = 0;
            //enquanto o contador for menor ou igual a 7 meu programa irá pedir para que seja informado
            //um caracter para o array
            while (contador <= 7) 
            {
                Console.WriteLine ("Insira um valor para o array");
                array[contador] = int.Parse (Console.ReadLine ());
                contador++;
            }

            //para a menor que o tamanho do meu array entao o a conta
            for (int a = 0; a < array.Length; a++) 
            {
                //para sort menor que o tamanho do lido da direita para a esquerda conta o sort
                for (int sort = 0; sort < array.Length - 1; sort++) 
                {
                    // se o array que recebe o valor de sort for menor que o array crescente
                    //entao aux recebe o valor de sort + 1
                    // sort +1 recebe o valor de sort
                    //sort recebe o valor de aux
                    //assim dentro do loop o o valor será substituido dentro das variaveis e assim
                    //criará uma sequencia crescente
                    if (array[sort] > array[sort + 1]) 
                    {
                        aux = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = aux;
                    }
                }
            }

            Console.WriteLine("Input array: ");

            //enquanto o contadorB for menor que o tamanho do array
            //a função ira printar na tela os elementos do array
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }

            for (int ord = 0; ord < array.Length; ord ++) {
                //para sort menor que o tamanho do lido da direita para a esquerda conta o sort
                for (int sort = 0; sort > array.Length + 1; sort++) 
                {
                    // se o array que recebe o valor de sort for menor que o array crescente
                    //entao aux recebe o valor de sort + 1
                    // sort +1 recebe o valor de sort
                    //sort recebe o valor de aux
                    //assim dentro do loop o o valor será substituido dentro das variaveis e assim
                    //criará uma sequencia crescente
                    if (array[sort] < array[sort - 1]) 
                    {
                        aux = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = aux;
                    }
                }
            }

            Console.WriteLine("\noutput array: ");

            //enquanto o contadorB for menor que o tamanho do array
            //a função ira printar na tela os elementos do array
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }
        
        }
    }
}
