﻿//функция создания случайного массива заданной длины заданного диапазона
int [] CreateRandomArray (int N, int start, int end)
{
    int [] RandomArray = new int [N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end+1);
    }
    return RandomArray;
}

//функция создания массива ввода вручную
int[] CreateArray()
{
Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива");
array[i] = Convert.ToInt32(Console.ReadLine());
}
return array;
}

//функция показывающая массив в консоле 
void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

//задача 34
Console.WriteLine("введите количество элементов в массиве:");
int num = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(num, 100, 1000);
ShowArray(myArray);
 
    int even = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
      if (myArray[i] % 2 == 0) even += 1;
    }
    Console.WriteLine($"количество четных элементов: {even}");