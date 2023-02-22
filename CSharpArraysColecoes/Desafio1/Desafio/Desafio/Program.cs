using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] array = new double[5];
            array.SetValue(17.5, 0);
            array.SetValue(19.3, 0);
            array.SetValue(43.3, 0);
            array.SetValue(63.2, 0);
            array.SetValue(8.5, 0);

            DescobreMedia(array);
            double valorTotal = 0;

            void DescobreMedia(double[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    valorTotal += array[i];
                }
                double media = valorTotal / array.Length;
                Console.WriteLine(media);
            }
        }
    }
}
