System.Console.WriteLine("Введите цифру обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 & number < 6)
{
    System.Console.WriteLine("Сегодня рабочий день");
}
else if (number > 5 & number < 8)
{
    System.Console.WriteLine("Сегодня выходной");
}
else
{
    System.Console.WriteLine("Вы ввели неправильную цифру дня, попробуйте снова");
}