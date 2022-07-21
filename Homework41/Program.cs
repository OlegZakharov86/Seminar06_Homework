// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

namespace Seminar6
{
    class Homework41
    {
        public static void Main()
        {
            Console.WriteLine("Введите несколько чисел");
            int [] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = CountArray(array);
            Console.WriteLine($"Вы ввели {count} чисел больше 0");

        }
        public static int CountArray(int[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0) count++;
            }
            return count;
        }
    }
}
