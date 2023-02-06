/*
## Primer3
В прямоугольной матрице найти строку с наименьшей суммой элементов.

*/

int rows = new Random().Next(5,10);    // количество строк
int cols = rows;                       // количество столбцов
int[,] numbers = new int [rows,cols];
int rowpoz = 0;
int tempdig = 0;
int calcsum =0;
fillmas(numbers);
Console.WriteLine("Начальный массив");
printmas(numbers);
tempdig = Getsumrow(numbers,0);

for (int i = 0; i < rows; i++)
{
    calcsum = Getsumrow(numbers,i);
    if (calcsum < tempdig) 
    {
        tempdig = calcsum;
        rowpoz = i;
    }
}


Console.WriteLine("Cтрока с наименьшей суммой элементов "+rowpoz+" Сумма элементов "+tempdig );

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
 int Getsumrow(int[,] array,int rownum)
{
int rows = array.GetUpperBound(0) + 1;    // количество строк
int columns = array.Length / rows;        // количество столбцов	
int sumrow = 0; 
    for (int i = 0; i < columns; i++)
    {
        sumrow = sumrow + array [rownum,i];
    }
		return  sumrow;	
}