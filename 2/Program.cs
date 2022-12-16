// Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
Random rand = new Random();
int m = rand.Next(0,10);
Console.WriteLine(m );
int n = rand.Next(0,10);
Console.WriteLine(n);
int max = Math.Max(m,n);
int min = Math.Min(m,n);
int sum = 0;
method();
void method()
{   
    min++;
    if(min==max)
    {
        Console.WriteLine($"Сумма={sum}");
        return;
    }
    sum=sum+min;    
    method();
}