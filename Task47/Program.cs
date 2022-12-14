Console.WriteLine("Выберите задание: ");
Console.WriteLine("Задание 47. Массив заполненный случайными числами");
Console.WriteLine("Задание 50. По позиции в массиве возвращение значения");
Console.WriteLine("Задание 52. Среднеарифметическое значение элементов в столбце");
int n = Convert.ToInt32(Console.ReadLine());

switch (n){
    case 47: Task47();
    break;
    case 50: Task50();
    break;
    case 52: Task52();
    break;
    default:
    break;
}

void Task47()
{

// Задача 47. Задайте вручную двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [m, n];
Random random = new Random();
for (int i = 0; i < m; i++)  
{
  for (int j = 0; j < n; j++) 
  {
    matrix[i, j] = random.Next(-10, 10) + random.NextDouble();
    Console.Write("{0,6:f1}", matrix[i, j]);
  }
  Console.WriteLine();
}
}


void Task50()
{

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m, n];
Random random = new Random();
for (int i = 0; i < m; i++) 
{ 
  for (int j = 0; j < n; j++) 
      {
      matrix[i, j] = random.Next(0, 10);
      Console.Write(matrix[i,j] + " ");
      }
  Console.WriteLine();
}
Console.WriteLine("Введите число для поиска в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
bool found = false;
for (int i = 0; i < m; i++)  
    {
        for (int j = 0; j < n; j++) 
              if (matrix[i,j] == number) 
              {
              Console.WriteLine(" Число {0} находится в массе на позиции: [{1}, {2}]", number, i,j); 
              found = true;
              }     
    }
 
if (found == false)
  Console.WriteLine(" Числa {0} нет в массиве", number); 
}



void Task52()
{
//Задача 52. Задайте двумерный массив из целых чисел. Вручную. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
// реднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,m];
double columnSum = 0; 
for (int i = 0; i < n; i++)  
    {
      Console.WriteLine("Введите {1} элемента {0} -ой строки массива через запятую", i+1, m);
 string[] input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0; j < m; j++) 
            {    
            matrix[i, j] = Convert.ToInt32(input[j]);
            }
    }
for (int j = 0; j < m; j++)  // по столбцам
{ 
  columnSum=0;
         for (int i = 0; i < n; i++) // по строкам
columnSum = (columnSum + matrix[i, j]); 
         double arithmeticMean = (columnSum/n);
         Console.WriteLine("Средне арифметичекое по стобцу {0} равно: " + arithmeticMean , j+1);
}
}