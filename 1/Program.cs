//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int size = 4;
int[] numbers = new int[size];
int sum = 0;
Fillarray(numbers);
PrintArray(numbers);
for(int i=0;i<size;i++)
{
    if(numbers[i]%2==0)
    {
        sum=sum+1;
    }
}
Console.WriteLine($"Количесвтво чётных чисел в массиве равно={sum}");



void Fillarray(int[] nums)
{
    Random rand = new Random();
    int lenght = nums.Length;
    for(int i=0;i<lenght;i++)
    {
        nums[i]= rand.Next(100,1000);
    }
}
void PrintArray(int[]nums)
{
    int lenght = nums.Length;
    Console.Write("binnary array = [");
    for(int i=0;i<lenght;i++)
    {
        Console.Write(nums[i] +", ");
    }
    Console.WriteLine("]");
}
