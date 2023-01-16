System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

string third = number.ToString();

if (number > 99)
{
    System.Console.WriteLine("Третья цифра вашего числа равна " + third[2]);
}
else
{
    System.Console.WriteLine("Число не имеет третьего разряда");
}



