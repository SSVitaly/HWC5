//функция создания случайного массива заданной длины заданного диапазона
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
Console.WriteLine("Задача 34");
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

//задача 36 
Console.WriteLine(" ");
Console.WriteLine("Задача 36");
Console.WriteLine("Введите количество элементов в массиве");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num1, min, max);
Console.WriteLine("Массив:");
    ShowArray(myRandomArray);
int oddNumber = 0;
     
    for (int i = 0; i < myRandomArray.Length; i++)
    {
      if (i % 2 == 0) oddNumber += myRandomArray[i];
    }
    Console.WriteLine($"сумма элементов на нечетных позициях, с учетом того что позиции нумеруются с 0: {oddNumber}");

//задача 38
Console.WriteLine(" ");
Console.WriteLine("Задача 38");
Console.WriteLine("Введите количество элементов в массиве");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max2 = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray2 = CreateRandomArray(num2, min2, max2);
Console.WriteLine("Массив:");
    ShowArray(myRandomArray2);
    int maxNumber = min2; 
    int minNumber = max2; 
      for (int i = 0; i < myRandomArray.Length; i++)
    {
      if (maxNumber < myRandomArray2[i]) maxNumber = myRandomArray2[i];
      if (minNumber > myRandomArray2[i]) minNumber = myRandomArray2[i];
    }
    int difference = maxNumber - minNumber;
    Console.WriteLine($"Разница между максимальным и минимальным элементами = {difference}");