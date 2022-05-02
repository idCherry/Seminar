Console.WriteLine("введите первое целое число ->");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе целое число ->");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
   Console.WriteLine(a + " больше " + b);
}
else
{
    Console.WriteLine(b + " больше " + a);
}
