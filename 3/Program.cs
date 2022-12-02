// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int size = 4;
double[] numbers = new double[size];
Fillarray(numbers);
PrintArray(numbers);
double min = numbers[0];
double max = numbers[0];
double diff = 0;
for(int i=1;i<size;i++)
{
    if(numbers[i]>max)
    {
        max=numbers[i];
    }
    else if(numbers[i]<min)
    {
        min=numbers[i];
    }
}
diff = max-min;
Console.WriteLine($"Разница между макс и мин ={diff}");


void Fillarray(double[] nums)
{
    Random rand = new Random();
    int lenght = nums.Length;
    for(int i=0;i<lenght;i++)
    {
        nums[i]= rand.Next(-10,10)+rand.NextDouble();
    }
}
void PrintArray(double[]nums)
{
    int lenght = nums.Length;
    Console.Write("binnary array = [");
    for(int i=0;i<lenght;i++)
    {
        Console.Write(nums[i] +", ");
    }
    Console.WriteLine("]");
}
