// 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

// SP – R$67.836,43
// RJ – R$36.678,66
// MG – R$29.229,88
// ES – R$27.165,48
// Outros – R$19.849,53

// Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor 
// total mensal da distribuidora.

namespace FaturamentoMensal
{
    public class FaturamentoMensal
    {
        static void Main(string[] args)
        {
            double SP = 67386.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double Outros = 19849.53;

            var total = SP + RJ + MG + ES + Outros;
            
            // Calculo de porcentagem de cada estado.
            double percentualSp = (100 / total) * SP;
            double percentualRj = (100 / total) * RJ;
            double percentualMg = (100 / total) * MG;
            double percentualEs = (100 / total) * ES;
            double percentualOutros = (100 / total) * Outros;

            Console.WriteLine($"O estado de SP teve, {percentualSp.ToString("F2")} % de representação no valor total mensal da Distribuidora!");
            Console.WriteLine($"O estado do RJ teve, {percentualRj.ToString("F2")} % de representação no valor total mensal da Distribuidora!");
            Console.WriteLine($"O estado de MG teve, {percentualMg.ToString("F2")} % de representação no valor total mensal da Distribuidora!");
            Console.WriteLine($"O estado do ES teve, {percentualEs.ToString("F2")} % de representação no valor total mensal da Distribuidora!");
            Console.WriteLine($"Os Outros estados juntos tiveram, {percentualOutros.ToString("F2")} % de representação no valor total mensal da Distribuidora!");
        }
       
    }
}