using System;
using static System.Console;

Clear();
string[] MyArray;
WriteLine("Введите числа/строки через пробел:");
string UserArray = ReadLine();
MyArray = UserArray.Split(' ');
var result = new string[MyArray.Length];
var size = 0;
foreach (var value in MyArray)
{
    if (value.Length <= 3)
    {
        result[size] = value;
        size++;
    }
}
string FinishArray = string.Join(" ", result, 0, size);
WriteLine();
WriteLine($"Данные, введенные пользователем: [{UserArray}]");
WriteLine();
WriteLine($"Полученный массив из строк, длина которых меньше, либо равна 3-м символам: [{FinishArray}]");
