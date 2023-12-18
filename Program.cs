# pragma warning disable

// Домашнее задание (семинар 4). Необходимо разделить логику алгоритмов на функции

// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве. 
// [344 452 341 125] => 2

/*
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int [] array = new int[num];

void CreateArray()
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
}
}

void PrintArray (int[]array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
    Console.Write("] => ");
}

int FindNumber()
{
int countNum = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i]%2 == 0)
    {
    countNum = countNum + 1;
    }
}
return countNum;
}

CreateArray();
PrintArray(array);
int countNum = FindNumber();
System.Console.Write(countNum);
*/

// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

/*
Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine());

int [] array = new int[num];

void CreateArray()
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
}
}

void PrintArray (int[]array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
    Console.Write("]");
}

void CreateArray2()
{
int j = num-1;
for (int i = 0; i < j; i++)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
    j--;
}
}

void PrintArray2 (int[]array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
    Console.Write("]");
}

CreateArray();
PrintArray(array);
Console.Write(" => ");
CreateArray2();
PrintArray(array);
*/
