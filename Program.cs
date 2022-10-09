/* Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
5
0
7
8
-2
-2 -> 2
5
1
-7
567
89
223-> 3 */
Console.Clear();

Console.WriteLine("введите число: ");
int numM = int.Parse(Console.ReadLine()!);

int[] numbersArr = new int[numM];

for (int i = 0; i < numbersArr.Length; i++)
{
    numbersArr[i] = int.Parse(Console.ReadLine()!);
}
int counterNumbers = NumbersCounter(numbersArr);
Console.WriteLine($"Положительных чисел: {counterNumbers}");

int NumbersCounter(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            counter++;
    }
    return counter;
}