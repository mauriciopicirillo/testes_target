// 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
// (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele 
// calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

// IMPORTANTE:
// Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

public class Fibonacci
    {
        public static void Main (string[] args) 
    {
        try 
        {
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci;

            Console.WriteLine("Informe o numero a ser comparado na tabela de Fibonacci: ");
            int novoNumero = int.Parse(Console.ReadLine());

                // laço de repetição para a tabela de Fibonacci
                for (int i = 1; i < novoNumero; i++)
                {                 
                    fibonacci = numeroAnterior + numeroAtual;
                    numeroAnterior = numeroAtual; 
                    numeroAtual = fibonacci;

                    if (novoNumero == fibonacci)
                    {
                        Console.WriteLine($" - O número {novoNumero} é igual a {fibonacci}, na tabela de Fibonacci");               
                    }
                    else
                    {
                        Console.WriteLine($" - O número {novoNumero} não é igual a {fibonacci}, na tabela de Fibonacci");
                    }
                    
                }                       
        }
        // caso a pessoa digite uma letra ao invés de um numero é disparado um erro e finaliza o programa.
        catch(Exception)
        {          
            Console.WriteLine("Erro!!! Foi digitado uma letra ao inves de um número, programa será finalizado...");            
        }      
    }
}


