/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое эл-тов в каждом столбце.*/
int rows = ReadInt("Enrer the number of rows in the array: ");
int columns = ReadInt("Enrer the number of columns in the array: ");

int [,] numbers = new int[rows,columns];
FillArrayRandomNumbers(numbers,rows,columns);
Console.WriteLine("Your array:");
PrintArray(numbers,rows,columns);

double sum = 0;
for (int j=0; j<columns; j++)
    {
        for (int i=0; i<rows; i++)
        {
            sum += numbers[i,j];
        }
        Console.WriteLine($"Average in columns {j+1}: {Math.Round(sum/rows,2)}");
        sum=0;
    }

void PrintArray(int[,] array, int rowsP, int columnsP)
{
    for (int i=0; i< rowsP; i++)
    {
        for (int j=0; j<columnsP; j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void FillArrayRandomNumbers(int[,] array, int rowsF, int columnsF)
{
    for (int i=0; i< rowsF; i++)
    {
        for (int j=0; j<columnsF; j++)
        {
            array[i,j] = Convert.ToInt32(new Random().Next(-10,11));
        }
    }
}

int ReadInt (string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}