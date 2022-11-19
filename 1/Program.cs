//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32((Console.ReadLine()));
int first = number/10; 
int tens = first%10;
Console.WriteLine(tens);