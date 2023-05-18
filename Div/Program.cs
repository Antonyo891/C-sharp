// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целые числа");
double Div = 1;
double numberA = int.Parse(Console.ReadLine());
double numberB = int.Parse(Console.ReadLine());
int Random = new Random().Next(1,3);
Console.Write("При делении числа ");
if (Random == 1) 
{ 
Console.Write(numberA);
}
else 
{
Console.Write(numberB);    
}
Console.Write(" на число ");
if (Random == 1) 
{ 
Console.Write(numberB);
Div = numberA/numberB;
}
else 
{
Console.Write(numberA);
Div = numberB/numberA;    
}
Console.Write(" получится ");
Console.WriteLine(Div);
Console.WriteLine(Random);