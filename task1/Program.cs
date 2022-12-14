Console.WriteLine("выберите задание");
Console.WriteLine("цифра 1 - задача 41");
Console.WriteLine("цифра 2 -задача 43");
int n = Convert.ToInt32(Console.ReadLine());

switch(n)
{
    case 1:
        task1();
        break;
    case 2:
        task2();
        break;
    default:
        break;
}

void task1()
{
Console.WriteLine("количество цифр");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите цифры");
int [] array = new int [length];
for (int i=0; i<array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"количество цифр больше 0 = {Sum(array)}");

int Sum (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > 0) sum ++;
    }
return sum;
}
}

void task2()
{
Console.WriteLine ("Введите k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите b2");
int b2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"две прямые пересекутся в точке с координатами X: {Point1(k1,k2,b1,b2)}, Y: {Point2(k1,k2,b1,b2)}");


double Point1 (double k1,double k2,double b1,double b2)
{
    double x = (b2 -b1)/(k1 - k2);
    return x; 
        
}
 double Point2(double k1,double k2,double b1,double b2)
{
    double x = (b2 -b1)/(k1 - k2);
    double y = k1 * x + b1;
    return y;
}
}