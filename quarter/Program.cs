System.Console.WriteLine("Задайте номер четверти от 1 до 4");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("Четверть номер 1, в ней X > 0 и Y > 0");
}

else if (number == 2)
{
    System.Console.WriteLine("Четверть номер 2, в ней X < 0 а Y > 0");
}

else if (number == 3)
{
    System.Console.WriteLine("Четверть номер 3, в ней X < 0 и Y < 0");
}

else if (number == 4)
{
    System.Console.WriteLine("Четверть номер 4, в ней X > 0 а Y < 0");
}

else
{
    System.Console.WriteLine("Вы ввели несуществующий номер четверти попробуйте снова");
}