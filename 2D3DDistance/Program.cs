System.Console.WriteLine("Если вам нужно найти расстояние в 2D пространстве, напишите 1, если 3D напишите 2");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("Введите координату X первого числа");
var first_x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y первого числа");
var first_y = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату X второго числа");
var second_x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y второго числа");
var second_y = Convert.ToInt32(Console.ReadLine());

var result = System.Math.Sqrt(System.Math.Pow(second_x - first_x, 2) + System.Math.Pow(second_y - first_y, 2));

System.Console.WriteLine(result);
}

else if (number == 2)
{
System.Console.WriteLine("Введите координату X первого числа");
var first_x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y первого числа");
var first_y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z первого числа");
var first_z = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату X второго числа");
var second_x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y второго числа");
var second_y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z второго числа");
var second_z = Convert.ToInt32(Console.ReadLine());

var result = System.Math.Sqrt(System.Math.Pow(second_x - first_x, 2) + System.Math.Pow(second_y - first_y, 2) + System.Math.Pow(second_z - first_z, 2));

System.Console.WriteLine(result);
}

else
{
    System.Console.WriteLine("Вы ввели неверное число, попробуйте еще раз");
}