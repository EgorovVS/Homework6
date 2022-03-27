/*Задача 1: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

Console.WriteLine("Сколько чисел вы хотите обработать?");
int check = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа");

int count = 0;
int[] arr = new int[check];
for (int i = 0; i < check; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    arr[i] = num;
    if (num > 0)
    {
        count++;
    }
}
PrintArray(arr);
Console.WriteLine($"Из введенных чисел {count} больше 0");


void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ");
    }
    Console.WriteLine();
}