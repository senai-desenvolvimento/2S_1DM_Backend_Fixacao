using System;

namespace reforco
{
    class Program
    {
        static float CalcularMedia(float[] numeros){

            float soma = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                // soma = soma + numeros[i];
                soma += numeros[i];
            }
            
            float calculo = soma / numeros.Length;

            return calculo;
        }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            /*
                array - aplicação
                foreach
                função/método            
            */
            string[] nomes       = new string[3];
            float [] mediaAluno  = new float[3];
            float [] notas       = new float[4];

            // 0
            // Mateus
            // 7.8

            // Laço contado
            // O laço FOR já tem na sua sintaxe elementos para contar números
            // Opções de incremento:
            // i++
            // i = i + 1
            // i += i
            for(int i = 0; i < 3; i++){

                Console.WriteLine("Escreva um nome : ");
                nomes[i] = Console.ReadLine();

                for (var x = 0; x < 4; x++)
                {
                    // Concatenação
                    Console.WriteLine("Digite a "+(x+1)+"° nota: ");
                    notas[x] = float.Parse(Console.ReadLine());
                }

                mediaAluno[i] = CalcularMedia(notas);

            }

            Console.ForegroundColor = ConsoleColor.Blue;

            // Laço condicionais
            // WHILE / DO WHILE / FOREACH
            foreach(string nomeAvulso in nomes)
            {
                Console.WriteLine(nomeAvulso);
            }

            Console.ForegroundColor = ConsoleColor.Red;

            // Mostrar médias e nomes em laços de repetição
            // array.Length = tamanho do array, caso eu não saiba (dinâmica)
            for (var i = 0; i < nomes.Length ; i++)
            {
                // Interpolação
                Console.WriteLine($"Nome : {nomes[i]} - Média : {mediaAluno[i]} ");
            }  
        }
    }
}
