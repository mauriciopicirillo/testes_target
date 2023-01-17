//  1) Observe o trecho de código abaixo:

// int INDICE = 13, SOMA = 0, K = 0;

// enquanto K < INDICE faça
// {
// K = K + 1;
// SOMA = SOMA + K;
// }

// imprimir(SOMA);

// Ao final do processamento, qual será o valor da variável SOMA?
 
 
 internal class Soma
    {
        private static void Main(string[] args)
        {
            int Indice = 13, Soma = 0, K = 0;

            while( K < Indice)
            {
                K = K + 1;
                Soma = Soma + K;
                Console.WriteLine(Soma);
            }
            
        }
    }