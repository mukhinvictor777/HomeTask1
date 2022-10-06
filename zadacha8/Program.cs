Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int countnumber = 1;
if (Number < 2)
{
   Console.WriteLine($"Четных положительных числел в выбранном диапазоне от 1 до {Number} нет");
}
else 
{
    while (countnumber <= Number)
    {
        if (countnumber % 2 == 0)
        {
            Console.WriteLine($"{countnumber}");
            countnumber++;
        }
        else
        {
            countnumber++;
        }
    }
}