using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
        Intermediário
        Princípios Básicos
    Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno.
    A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 
    (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

    Entrada
    O arquivo de entrada contém 2 valores com uma casa decimal cada um.

    Saída
    Calcule e imprima a variável MEDIA conforme exemplo abaixo, com 5 dígitos após o ponto decimal 
    e com um espaço em branco antes e depois da igualdade. Utilize variáveis de dupla precisão (double) 
    e como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, 
    você receberá "Presentation Error".
 */
namespace DesafiosAritmeticos
{
    public class Media
    {
        public static void RespostaDesafioMedia() 
        {

            double a, b, mediaP;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            mediaP = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));

        }

        //Estudo com validação de entrada
        public static void DesafioDaMedaia()
        {
            double mediaP;

            Console.Write("Informe a nota a: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                do
                {
                    Console.Write("Valor Inválido! \n Tente novamente:");

                } while (!double.TryParse(Console.ReadLine(), out a));

            }

            Console.Write("Informe a nota B: ");
            if (!double.TryParse(Console.ReadLine(),out double b))
            {
                do
                {
                    Console.Write("Valor Inválido! \n Tente novamente:");

                } while (!double.TryParse(Console.ReadLine(), out b));

            }

            mediaP = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));
            Console.ReadKey();
        }

        /// <summary>
        /// estudo com validação de ponto ou virgula para decimais
        /// </summary>
        public static void DesafioDaMedaia2()
        {
            double mediaP;

            Console.Write("Informe a nota a: ");
            if (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double a))
            {
                do
                {
                    Console.Write("Valor Inválido! \n Tente novamente:");

                } while (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out a));

            }

            Console.Write("Informe a nota B: ");
            if (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double b))
            {
                do
                {
                    Console.Write("Valor Inválido! \n Tente novamente:");

                } while (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out b));

            }

            mediaP = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }

    }
}
