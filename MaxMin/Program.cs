// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите 10 целых чисел");
int count = 0, index=0; 
int[] array = new int[10];
while(count<10) 
{
    array[count] = int.Parse(Console.ReadLine());
    count = count + 1;
}
int iMax=0, iMin=0;
while(index<10)
{
    if(array[index]>array[iMax])
    {
        iMax=index;
    } else
    {
        if(array[index]<array[iMin])
        {
            iMin=index;
        }
    } 
    index=index+1;  
}
Console.Write("Макимальное число - ");
Console.WriteLine(array[iMax]);
Console.Write("Минимальное число - ");
Console.WriteLine(array[iMin]);
