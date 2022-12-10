// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int m = 4;
int n = 3;
int[,]numbers = new int[m, n];
Fillarray(numbers,0,6);
PrintArray(numbers);
int rows = numbers.GetLength(0);
int columns = numbers.GetLength(1);
int sum = 0;
int min = 0;
int minsum = 0;
for(int i=0;i<rows;i++)
    {      
        sum = 0;
        for(int j = 0; j < columns; j++)
        { 
            sum = sum+numbers[i,j];
        }
        if(i == 0)
        {   
            minsum = sum;
        }
        if(sum<minsum)
        {
            minsum=sum;
            min = i;
        }
    }
Console.WriteLine($"Строка с наименьшей суммой элементов = {min}");
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
        Console.Write("[");
        for(int j = 0; j < columns; j++)
        { 
            Console.Write(nums[i,j] +", ");
        }
        Console.WriteLine("]");
    }
}