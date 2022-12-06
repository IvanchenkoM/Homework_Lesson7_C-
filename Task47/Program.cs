// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.
int rows = ReadInt("Enrer the number of rows in the array: ");
int columns = ReadInt("Enrer the number of columns in the array: ");

double [,] numbers = new double[rows,columns];
FillArrayRandomNumbers(numbers,rows,columns);
Console.WriteLine("Your array:");
PrintArray(numbers,rows,columns);

void PrintArray(double[,] array, int rowsP, int columnsP)
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

void FillArrayRandomNumbers(double[,] array, int rowsF, int columnsF)
{
    for (int i=0; i< rowsF; i++)
    {
        for (int j=0; j<columnsF; j++)
        {
            int randomNumber = new Random().Next(100,1000);
            array[i,j] = Convert.ToDouble(randomNumber)/10;
        }
    }
}

int ReadInt (string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}