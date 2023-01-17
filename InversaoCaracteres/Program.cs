// 5) Escreva um programa que inverta os caracteres de um string.

// IMPORTANTE:
// a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
// b) Evite usar funções prontas, como, por exemplo, reverse;


using System.Text;

namespace InversaoCaracteres
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra para que possa ser feita a inversão de caracteres: ");
            string palavra = Console.ReadLine();
            
            //Instancia um objeto da classe StringBuilder.
            StringBuilder letras = new StringBuilder();           
            
            //Repete o último ao primeiro índice da string palavra em i... 
            for(var i = palavra.Length-1; i>=0; i--)
            {
                //...acrescenta o caracter palavra[i] ao final do objeto StringBuilder.
                letras.Append(palavra[i]);                             
            }
            Console.WriteLine(letras.ToString());
                    }         
                }
}


