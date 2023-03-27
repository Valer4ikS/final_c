/* Задача.
Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

using static System.Console;
Clear();

int N = Convert.ToInt32(Prompt("Введите количество элементов исходного массива n: "));
// int minM = Convert.ToInt32(Prompt("Введите минимальную длину строки для нового массива m: "));

const int minM = 3; // минимальна длина строки для нового массива

if (N < 1)
{
    WriteLine("Кол-во элементов должно быть больше нуля!");
    return;
}


string[] array1 = GetArray(N);
string[] array2 = GetElementN(array1);

Write("Исходный массив -> ");
PrintArray(array1);
WriteLine();
Write("Финальный массив -> ");
PrintArray(array2);

// запрашиваем у пользователя ввод строки 
string Prompt(string message)
{
    Write(message);
    String value = ReadLine()!;
    return value;
}

// вводим определенный элемент массива
string[] GetElement(int n)
{
    string[] result = new string[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = Prompt($"Введите {i + 1} элемент массива: ");
    }
    return result;
}
// считаем кол-во элементов с длиной <= minM символов
int GetCountBelowN(string[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item.Length <= minM) count++;
    }
    return count;
}
