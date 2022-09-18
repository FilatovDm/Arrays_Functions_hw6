/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int GetQtyPositiveNumbers(int[] array)
{
    var qty = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            qty++;
        }
    }
    return qty;
}

Console.Write("Введите через пробел отрицательные и положительные числа: ");
string line = Console.ReadLine();
string[] splitString = line.Split(' ');

// Перевожу масиив из строки в целочисленный. Может это можно было сделать лаконичнее?
// Или этот цикл в метод отнести и слить его в один цикл (стока 10) 
// и сразу после преобразования в int услловием считать array[i] > 0 
int[] array = new int[splitString.Length];
for (int i = 0; i < splitString.Length; i++)
{
    array[i] = Convert.ToInt32(splitString[i]);
}

var qtyPositiveNumbers = GetQtyPositiveNumbers(array);
Console.WriteLine("Количество чисел больше 0: " + qtyPositiveNumbers);
