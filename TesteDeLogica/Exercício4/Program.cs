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

            //Os elementos do array serão comparados 
            for (int j = 0; j < array.Length; j ++) {                
                    

                for (int i = j+1; i < array.Length; i++)
                {
                    //cada elemento da posição i será comparado com o elemento da posição j + 1, ou seja, um 
                    //elemento da posição 2 será comparado com o elemento da posição 3. Caso o elemento da 
                    //posição 2 for maior que o da posição 3, eles trocam de lugar e assim sucessivamente.                     
                    if (array[j] > array[i])
                    {
                        aux = array[j];

                        array[j] = array[i];

                        array[i] = aux;
                    }
                }
            }

            Console.WriteLine("Input array: ");

            //enquanto o contadorB for menor que o tamanho do array
            //a função ira printar na tela os elementos do array
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }
        
        }
    }
}
