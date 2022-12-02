//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
int size = 6;
int[] numbers = new int[size];
Fillarray(numbers);
PrintArray(numbers);
int sum = 0;
for(int i=1;i<size;i+=2)
{
    sum=sum+numbers[i];
}
Console.Write($"Сумма элементов с нечётными индексами={sum}");
void Fillarray(int[] nums)
{
    Random rand = new Random();
    int lenght = nums.Length;
    for(int i=0;i<lenght;i++)
    {
        nums[i]= rand.Next(-10,10);
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
