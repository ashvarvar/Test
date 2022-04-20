//вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = Cordinate("x", "A");
int y1 = Cordinate("y", "A");
int z1 = Cordinate("c", "A");
int x2 = Cordinate("x", "B");
int y2 = Cordinate("y", "B");
int z2 = Cordinate("c", "B");

int Cordinate(string coorName, string pointName)
{
    Console.WriteLine($"Введинте {coorName} точки {pointName}");
    return Convert.ToInt32(Console.ReadLine());
}

  
double distance = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);

Console.WriteLine($"Расстояние между точками = {distance}");



