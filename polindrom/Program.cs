System.Console.WriteLine("Введите пятизначное число, для проверки на палиндром");
int number = Convert.ToInt32(Console.ReadLine());

int first = number / 10000;

int last = number % 10;

int second = number / 1000;
second = second % 10;

int per_last = number % 100;
per_last = per_last / 10;


if (first == last & second == per_last)
{
    System.Console.WriteLine("Число является палиндромом");
}
else
{
    System.Console.WriteLine("Число не является палиндромом");
}

