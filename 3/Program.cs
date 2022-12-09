// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int m = 4;
int n = 3;
int[,]numbers = new int[m, n];
Fillarray(numbers,0,5);
PrintArray(numbers);
double sum = 0;
double mid = 0;
int rows = numbers.GetLength(0);
int columns = numbers.GetLength(1);
for(int i=0;i<columns;i++)
{
    sum=0;
    for(int j = 0; j < rows; j++)
    { 
        sum = sum + numbers[j,i];
    }
    Console.WriteLine(mid=sum/rows);
}




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

