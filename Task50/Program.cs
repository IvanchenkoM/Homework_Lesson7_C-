/* Напишите программу, которая на вход принимает позицию эл-та в двумерном массиве,
и возращает значение этого элемента 
или же указание, что такого эл-та нет.*/

int rows = ReadInt("Enrer the number of rows in the array: ");
int columns = ReadInt("Enrer the number of columns in the array: ");

int [,] numbers = new int[rows,columns];
FillArrayRandomNumbers(numbers,rows,columns);
Console.WriteLine("Your array:");
PrintArray(numbers,rows,columns);

int userNumber = ReadInt("Enter the number: ");

bool have = false;
for (int i=0; i< rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            if (numbers[i,j] == userNumber)
            {
                have = true;
                break;
            }
            
            
        }        
    }

if(have)
    Console.WriteLine($"In this array is your number {userNumber}.");
else
    Console.WriteLine($"In this array isn't your number {userNumber}.");

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
            array[i,j] = Convert.ToInt32(new Random().Next(-100,1000));
        }
    }
}

int ReadInt (string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}