// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
Random randomizer = new Random();
 int size = 8;
 int[] numbers = new int[size];
Console.Write("binnary array = [");
 for(int i=0;i<8;i++)
{
    numbers[i]= randomizer.Next(-9,9);
     Console.Write(numbers[i] +",");
    }
 Console.WriteLine("]");
 for(int x=0;x<8;x++)
 {
    for(int i=x;i<8;i++)
    {
        if(Math.Abs(numbers[x])>Math.Abs(numbers[i]))
        {
            int t = numbers[i];
            numbers[i]=numbers[x];
            numbers[x]= t;
        }
    }
 }
Console.Write("binnary array = [");
Console.Write(numbers[0] +",");
Console.Write(numbers[1] +",");
Console.Write(numbers[2] +",");
Console.Write(numbers[3] +",");
Console.Write(numbers[4] +",");
Console.Write(numbers[5] +",");
Console.Write(numbers[6] +",");
Console.Write(numbers[7] +",");
Console.WriteLine("]");

