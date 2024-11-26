using System.Globalization;

namespace CalculoArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, PrecoMetroQuadrado, area, preco;

            Console.WriteLine("Digite a largura do terreno");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do terreno");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o preço do M²");
            PrecoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            area = largura * comprimento;
            preco = area * PrecoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor do preço do seu terreno é R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}
