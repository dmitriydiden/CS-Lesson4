
Console.Clear();
/* Выводим двумерный строчный массив
string[,] table=new string[2,5];
for(int i =0; i<2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"-{table[i,j]}-");
    }
    Console.WriteLine();
}*/

/* Выводим двумерный числовой массив
int[,] matrix = new int[4,5];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}*/
/* Выводим двумерный числовой массив c использованием счетчика GetLength
int[,] matrix = new int[4,5];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}*/
// Выводим двумерный числовой c помощью метода и заполняем массив с помощью метода
int[,] matrix = new int[4,5];
printarray(matrix);
Console.WriteLine();
Fillarray(matrix);
printarray(matrix);

void printarray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
}
}
void Fillarray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
}