// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int m = 4;
int n = 4;
int[,]numbers = new int[m, n];
Fillarray(numbers,0,20);
PrintArray(numbers);
int rows = numbers.GetLength(0);
int columns = numbers.GetLength(1);
for(int i=0;i<rows;i++)
    {
        for(int j = 0; j < columns; j++)
        { 
            for(int x=0; x < columns;x++)
                {
                    if((numbers[i,x])<(numbers[i,j]))
                        {
                           (numbers[i,x],numbers[i,j])=(numbers[i,j],numbers[i,x]);
                        }
                }
        }
    }
Console.WriteLine();
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
            nums[i,j] =rand.Next(minValue,maxValue);
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