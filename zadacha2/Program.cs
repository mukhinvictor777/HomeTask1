Console.WriteLine("Введите первое число");
int userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int userNumberB = Convert.ToInt32(Console.ReadLine());
if (userNumberA == userNumberB)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (userNumberA > userNumberB)
    {
    Console.WriteLine($"max = {userNumberA}");
    }
    else
    {
        Console.WriteLine($"max = {userNumberB}");
    }
}