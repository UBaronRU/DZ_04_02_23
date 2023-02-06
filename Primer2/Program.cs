/*
## Primer2
Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
*/
int rows = new Random().Next(5,10);    // количество строк
int cols = new Random().Next(5,10);    // количество столбцов
int[,] numbers = new int [rows,cols];
int tempdig = 0;

fillmas(numbers);
Console.WriteLine("Начальный массив");
printmas(numbers);
for (int i = 0; i < rows; i++)
{
    BubbleSort(numbers,i);
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
 void BubbleSort(int[,] array,int rownum)
{
int rows = array.GetUpperBound(0) + 1;    // количество строк
int columns = array.Length / rows;        // количество столбцов	
    
    for (int i = 0; i < columns; i++)
		for (int j = 0; j < columns - 1; j++)
			if (array[rownum,j] > array[rownum,j + 1])
			{
				int t = array[rownum,j + 1];
				array[rownum,j + 1] = array[rownum,j];
				array[rownum,j] = t;
			}
}