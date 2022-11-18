//Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32((Console.ReadLine()));
int i=2;
while(i<number1+1)
{
    Console.Write(i);
    Console.Write(",");
    i++;
    i++;
}