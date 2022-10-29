// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Clear();
// Console.WriteLine("Введите цифру размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] arrey=new int [size];

// void Random (int[] arrey)
// {
//     for (int i=0; i<arrey.Length; i++)
//     arrey [i]=new Random().Next(100,1000);
// }

// void Print (int[] arrey)
// {
//     for (int i=0; i<arrey.Length; i++)
//     Console.Write ($"{arrey[i]}  ");
// }

// void Amount (int[] arrey)
// {
//     int amount =0;
//     for (int i=0; i<arrey.Length; i++)
//     if (arrey[i]%2 == 0)
//     {
//       amount++;
//     }
//     Console.WriteLine(amount);
// }

// Random (arrey);
// Print (arrey);
// Console.WriteLine();
// Amount (arrey);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Clear();
// Console.WriteLine("Введите цифру размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] arrey=new int [size];
// int sum = 0;
// for (int i=0; i<arrey.Length; i++)
// {
//     arrey [i]=new Random().Next(1,10);
//     Console.Write (arrey[i]+ "  ");
//     if (i%2!=0)
//     {
//         sum = sum + arrey[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine(sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Введите цифру размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] arrey=new int [size];
for (int i=0; i<arrey.Length; i++)
{
    arrey [i]=new Random().Next(1,100);
    Console.Write ($"{arrey[i]}  ");
}
int min = arrey[0];
for (int i=0; i<arrey.Length; i++)
{
    if (arrey[i]<min)
    {
        min=arrey[i];
    }
}
int max=arrey[0];
for (int i=0; i<arrey.Length; i++)
{
    if (arrey[i]>max)
    {
        max=arrey[i];
    }
}
Console.WriteLine();
Console.WriteLine(max-min);
