// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество точек");
int count = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты вершины A");
Console.Write("XA - ");
int XA = int.Parse(Console.ReadLine());
Console.Write("YA - ");
int YA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты вершины B");
Console.Write("XB - ");
int XB = int.Parse(Console.ReadLine());
Console.Write("YB - ");
int YB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты вершины C");
Console.Write("XC - ");
int XC = int.Parse(Console.ReadLine());
Console.Write("YC - ");
int YC = int.Parse(Console.ReadLine());
int[] arrayX = new int[]{XA,XB,XC};
int[] arrayY = new int[]{YA,YB,YC};
int index = 0, X=arrayX[0], Y=arrayY[0];
Console.Clear();
while (index<3)
{
    Console.SetCursorPosition(arrayX[index],arrayY[index]);
    Console.WriteLine("+");
    index++;
}
index=0;
while (index<count)
{
    int what = new Random().Next(0,3);
    X=(X+arrayX[what])/2;
    Y=(Y+arrayY[what])/2;
    Console.SetCursorPosition(X,Y);
    Console.WriteLine("+");
    index++;
}
Console.SetCursorPosition(1,arrayY[2]+1);