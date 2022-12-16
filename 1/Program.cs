// Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
Random rand = new Random();
int m = rand.Next(0,2);
Console.WriteLine(m );
int n = rand.Next(0,20);
Console.WriteLine(n);
int max = Math.Max(m,n);
int min = Math.Min(m,n);
method();
void method()
{   
    min++;
    if(min==max)return;
    
    if(min%3==0)
    Console.Write($"{min},");
    method();
}