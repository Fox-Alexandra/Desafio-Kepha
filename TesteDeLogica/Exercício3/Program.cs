using System;
using System.Collections.Generic;

namespace Exercício3 {
    class Program {

        static void Main (string[] args) {
            //variavéis globais
            int x;
            int soma = 0;
            int[] array = new int[8];
            List<int> valores = new List<int>(); //lista para receber os elementos do array

            int contador = 0;
            //enquanto o contador for menor ou igual a 7 meu programa irá pedir para que seja informado
            //um caracter para o array
            while (contador <= 7) 
            {

                Console.WriteLine ("Insira um valor para o array");
                array[contador] = int.Parse (Console.ReadLine ());
                contador++;
            }

            //O programa irá solicitar um valor para X
            Console.WriteLine ("Informe um valor para 'X':");
            x = int.Parse (Console.ReadLine ());

            // i inicia em 0, para i menor ou igual a 7, i será contado
            for (int i = 0; i <= 7; i++) 
            {
                //se o valor da soma dos elementos do array forem menor ou igual ao valor de X
                // entao a variavel soma irá receber o valor da soma + o valor do elemento seguinte do array
                // e minha lista de valores irá receber os elementos do array
                //ao chegar no proximo valor maior que X minha função para e o pragrama sai do loop
                if (soma <= x) {
                    soma += array[i];
                    valores.Add(array[i]);

                } else {
                    break;
                }
            }

            //utilizado na estilização do console
            Console.Write ("array [] = {");

            //enquanto o contadorB for menor ou igual a 7
            //a função ira printar na tela os elementos do array
            int contadorB = 0;
            while (contadorB <= 7) 
            {
                Console.Write ($"{array[contadorB]},");
                contadorB++;
            }

            //utilizado na estilização do console
            Console.Write ("}");

            //Printa na tela o valor informado para X
            Console.WriteLine ($"\n X = {x}");

            //Printa na tela a quantidade de elementos que foram utilizados na soma
            Console.WriteLine ("\nOutput = "+valores.Count);

            //utilizado na estilização do console
            Console.Write ("Tamanho mínimo do subarray é: {");

            //Para cada item contido na lista valores, será printado os elementos desta lista
            //os elementos que foram somados serão printados no consol
            foreach (var item in valores)
            {
                System.Console.Write($"{item},");
            }

            //utilizado na estilização do console
            Console.Write ("}");
        
        }
    }
}