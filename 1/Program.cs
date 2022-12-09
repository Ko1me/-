// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
int m = 3;
int n = 4;
double[,]numbers = new double[m, n];
Fillarray(numbers,-9,10);
PrintArray(numbers);


void Fillarray(double[,] nums,int minValue,int maxValue)
{
    Random rand = new Random();
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    for(int i=0;i<rows;i++)
    {
        for(int j = 0; j < columns; j++)
        { 
            nums[i,j] = Math.Round(rand.Next(-10,10)+rand.NextDouble(),1);
        }
    }
    
}
void PrintArray(double[,]nums)
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