// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int m = 7;
int n = 4;
int[,]numbers = new int[m, n];
Fillarray(numbers,0,10);
PrintArray(numbers);

void Fillarray(int[,] nums,int minValue,int maxValue)
{
    Random rand = new Random();
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    for(int i=0;i<rows;i++)
    {
        for(int j = 0; j < columns; j++)
        { 
            nums[i,j]= rand.Next(minValue,maxValue);
        }
    }
    
}
void PrintArray(int[,]nums)
{
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    for(int i=0;i<rows;i++)
    {
        Console.Write("binnary array = [");
        for(int j = 0; j < columns; j++)
        { 
            Console.Write(nums[i,j] +", ");
        }
        Console.WriteLine("]");
    }
}
Console.WriteLine("Введите строки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбцы");
int columns = Convert.ToInt32(Console.ReadLine());
if(rows>numbers.GetLength(0)-1|columns>numbers.GetLength(1)-1)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine(numbers[rows,columns]);
}