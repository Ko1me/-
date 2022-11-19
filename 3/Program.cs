//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели");
int number1 = Convert.ToInt32(Console.ReadLine());
if(number1==1)
{
    Console.WriteLine("Пн, Нет");
    }else {if(number1==2)
    {
    Console.WriteLine("Вт, Нет");
    }
    else {if(number1==3)
    {
    Console.WriteLine("Ср, Нет");
    } else {if(number1==4)
    {
    Console.WriteLine("Чт, Нет");
    } else {if(number1==5)
    {
    Console.WriteLine("Пт, Нет");
    } else {if(number1==6)
    {
    Console.WriteLine("Сб, Да");
    } else {if(number1==7)
    {
    Console.WriteLine("Вс,Да");
    } 
}
}
}
}
}
}
