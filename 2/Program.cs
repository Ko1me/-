// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int number = Convert.ToInt32((Console.ReadLine()));
int number2 = number;
int sum = 0;
while(number>=1)
{
    number2=number%10;
    sum=sum+number2;
    number=number/10;
}
Console.WriteLine($"Сумма цифр в числе = {sum}");