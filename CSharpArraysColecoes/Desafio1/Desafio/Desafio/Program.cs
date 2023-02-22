using System;

double[] array = new double[5];
array.SetValue(17.5, 0);
array.SetValue(19.3, 1);
array.SetValue(43.3, 2);
array.SetValue(63.2, 3);
array.SetValue(8.5, 4);

DescobreMedia(array);


void DescobreMedia(double[] array)
{
    double valorTotal = 0;
    double media = 0;

    for (int i = 0; i < array.Length; i++)
    {
        valorTotal += array[i];
    }
    media = valorTotal / array.Length;
    Console.WriteLine($"A média dos valores do array é {media.ToString("F2")}");
}