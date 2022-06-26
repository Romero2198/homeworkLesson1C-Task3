Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a%2;
if (b == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}