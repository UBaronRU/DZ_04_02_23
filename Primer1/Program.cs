/*
## Primer1
Написать программу, которая обменивает элементы первой строки и последней строки
*/

int rows = new Random().Next(5,10);    // количество строк
int cols = new Random().Next(5,10);    // количество столбцов
int[,] numbers = new int [rows,cols];
int tempdig = 0;

fillmas(numbers);
Console.WriteLine("Начальный массив");
printmas(numbers);
for (int i = 0; i < cols; i++)
{
    tempdig = numbers[0,i];
    numbers[0,i] = numbers[rows-1,i];
    numbers[rows-1,i]=tempdig;
}
Console.WriteLine("Обработанный массив");
printmas(numbers);

void printmas(int[,] arr)
{
int rows = arr.GetUpperBound(0) + 1;    // количество строк
int columns = arr.Length / rows;        // количество столбцов
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
}
}
void fillmas(int[,] arr)
{
int rows = arr.GetUpperBound(0) + 1;    // количество строк
int columns = arr.Length / rows;        // количество столбцов
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = new Random().Next(-100,+100);
    }
   }
}

