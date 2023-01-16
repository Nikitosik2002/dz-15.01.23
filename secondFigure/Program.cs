System.Console.WriteLine("Введите трехзначное число, чтобы найти его вторую цифру");
int number = Convert.ToInt32(Console.ReadLine());

int figure = number % 100;
figure = figure / 10;
System.Console.WriteLine(figure);