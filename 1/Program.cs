//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int M = 7;
int sum = 0;
for(int i = 0;i<M;i++)
{
    Console.WriteLine("введите число");
    int numbers = Convert.ToInt32(Console.ReadLine());
    if(numbers>0)
    {
        sum=sum+1;
    }
}
Console.WriteLine($"Количество чисел больше 0 = {sum}");