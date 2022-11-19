// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число 1");
int number = Convert.ToInt32((Console.ReadLine()));
int first = number;
if(number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    for(int i=0;first>999;i++)
{
    number = number/10;
    first= number;
}
int number3 =first%10;
Console.WriteLine(number3);
}
