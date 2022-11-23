// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Random rand = new Random();
int aX = rand.Next(-10,10);
int aY = rand.Next(-10,10);
int aZ = rand.Next(-10,10);
int bX = rand.Next(-10,10);
int bY = rand.Next(-10,10);
int bZ = rand.Next(-10,10);
Console.WriteLine($"A({aX},{aY},{aZ})");
Console.WriteLine($"B({bX},{bY},{bZ})");
Console.WriteLine(Math.Pow(bX-aX,2));
Console.WriteLine(Math.Pow(bY-aY,2));
Console.WriteLine(Math.Pow(bZ-aZ,2));
Console.WriteLine(Math.Pow(bX-aX,2)+Math.Pow(bY-aY,2)+Math.Pow(bZ-aZ,2));
Console.Write("Разница между координатами = ");
Console.Write(Math.Sqrt(Math.Pow(bX-aX,2)+Math.Pow(bY-aY,2)+Math.Pow(bZ-aZ,2)));
