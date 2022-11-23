//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32((Console.ReadLine()));
int first = (number/10000)%10; 
int two = (number/1000)%10;
int four =(number/10)%10;
int five =number%10;
if(first==five && two==four)
{
    Console.WriteLine("Данное число является палиндромом");
}
else
{
    Console.WriteLine("Данное число НЕ является палиндромом");
}
