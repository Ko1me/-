//Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
Console.WriteLine("Введите натуральное число число А");
int numberA = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine("Введите натуральное число число B");
int numberB = Convert.ToInt32((Console.ReadLine()));
Console.WriteLine(Math.Pow(numberA,numberB));