using System; 
using System.Collections.Generic;

namespace Exercício1 {
    class Contagem { 
        
        // Definindo a função com o tamanho do alfabeto
        static int quantCaracteres = 256; 

        //declaro meu vetor do tipo char aonde este vator recebe o tamanho da minha string fornecida
        static char []contador = new char[quantCaracteres]; 
        
        //Contando os caracteres
        //Instancio um void para usar a função no meu calculo
        static void contagem(string palavra)
        { 
            //variavel i inicia com 0, para i menor que o tamanho da palavra conte i
            for (int i = 0; i < palavra.Length; i++) 
            {
                contador[palavra[i]]++; 
            }
        } 
        
        //Retornando primeira letra não repetida
        //Instancio um inteiro naoRepetida para usar a função no meu calculo
        static int naoRepetida(string palavra)  
        { 
            //puxa o valor da memoria do metodo contagem
            contagem(palavra); 
            int index = -1; //caracteres repetidos receberão o valor -1
            int i; 
        
            // meu i inicia com 0, para i  menor que o tamanho da minha string
            // entao i será contado i++
            for (i = 0; i < palavra.Length; i++) 
            { 
                //se meu vetor contador[palavra[i]] for igual a 1 (se o caracter nao repetir recebe 1)
                //então minha variavel index receberá o valor de i e a funçao irá parar
                if (contador[palavra[i]] == 1)  
                { 
                    index = i; 
                    break; 
                } 
            } 
            
        return index; //retorno o index para ser utilizado no proximo método
        } 
        
        // Método final 
        public static void Main() 
        { 
            Console.WriteLine("Informe uma palavra:");
            string palavra = Console.ReadLine(); 
            int index = naoRepetida(palavra); // index recebe o metodo "naoRepetida"
            
            Console.WriteLine(index == -1 ? "Todos os caracteres se repetem" : "Primeiro caractere não repetido é: "+ palavra[index]); 
        } 
    }
} 

