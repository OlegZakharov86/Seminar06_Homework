// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

namespace Seminar6
{
    class Homework43
    {
        public static void Main()
        {
            double[]array1 = new double[2];
            double k1 = array1[0];
            double b1 = array1[1];
            double[]array2 = new double[2];
            double k2 = array2[0];
            double b2 = array2[1];
            Console.WriteLine("Введите значения k1 и b1");
            array1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Console.WriteLine("Введите значения k2 и b2");
            array2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] crossOfTwoArrays = new double[2];
            crossOfTwoArrays[0] = (array2[1] - array1[1])/(array1[0] - array2[0]);
            crossOfTwoArrays[1] = array1[0] * crossOfTwoArrays[0] + array1[1];
            Console.WriteLine($"({crossOfTwoArrays[0]}, {crossOfTwoArrays[1]})");

        }
    }
}
