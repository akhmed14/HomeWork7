// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

Console.Write("Введите кол-во строк:");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов:");
int columns = int.Parse(Console.ReadLine());
double [,] array = new double [rows,columns];
GetArray(array);
PrintArray(array);

void GetArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(-9,9);
        }   
    }

}
void PrintArray ( double [,] arrray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}