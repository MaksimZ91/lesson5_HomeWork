Console.Clear();
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] initArray (int N)
// {
//   int[] array = new int[N];
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(100, 999);
//   }
//   return array;
// }

// int countEvenNumber (int[] array)
// {
//    int count = 0;
//    for (int i = 0; i < array.Length; i++)
//   {   
//     if ( array[i] % 2 == 0 )
//     count++;
//   }
//   return count;
// }
// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = initArray(N);
// Console.WriteLine("Исходный массив: [ " + string.Join(", ", array) + " ]");
// Console.WriteLine("Количество чётных чисел в массиве: " + countEvenNumber(array));



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0.

// int[] initArray (int N)
// {
//   int[] array = new int[N];
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(-100, 101);
//   }
//   return array;
// }

// int sum(int[] array)
// {
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//   {   
//     if ( i % 2 != 0 )
//     sum += array[i];
//   }
//   return sum;
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = initArray(N);
// Console.WriteLine("Исходный массив: [ " + string.Join(", ", array) + " ]");
// Console.WriteLine("Сумма элементов стоящих на нечётных позициях равна: " + sum(array));



// Задача 38: Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,5 7,78 22 2,23 78, 25] -> 76,02

// double[] initArray (int N)
// {
//   double[] array = new double[N];
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(1, 999) / 10.0;
//     //array[i] = new Random().NextDouble();
//   }
//   return array;
// }

// double diff(double[] array)
// {
//    double diff = 0;
//    int max = 0;
//    int min = array.Length-1;
//    for (int i = 0; i < array.Length; i++)
//   {   
//    if (array[i] > array[max])
//       max = i;
//    if (array[i] < array[min])
//       min = i;  
//   }
//   diff = array[max] - array[min];
//   return diff;
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// double[] array = initArray(N);
// Console.WriteLine("Исходный массив: [ " + string.Join(", ", array) + " ]");
// Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + diff(array));





//Дополнительная задача

int[] initArray (int N)
{
  int[] array = new int[N];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1, 10);
  }
  return array;
}


Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = initArray(N);
Console.Write("Введите сдвиг: ");
int K = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Исходный массив: [ " + string.Join(", ", array) + " ]");
Console.WriteLine("Сдвинутый массив: [ " + string.Join(", ", shift(array, K)) + " ]");


int[] shift (int[] array, int K)
{
    int[] arr = new int[array.Length];                  
    if ( K < 0)                                        
    {
      K = -K;                                         
      if (K > array.Length)                            
        K -= ( K / array.Length ) * array.Length;      
        K =  array.Length - K;                         
        transforArray(array, arr, K);                  
    }
    else
    {
      if (K > array.Length)
      K -= ( K / array.Length ) * array.Length;
      transforArray(array, arr, K);
    }
    return arr;
}


void transforArray (int[] array, int[] arr, int K)
{
  for(int i = 0; i < K; i++)                 
    arr[i] = array[array.Length - K + i ];  
  for(int j = K; j <= arr.Length-1; j++)
    arr[j] = array[j-K];                 
}






