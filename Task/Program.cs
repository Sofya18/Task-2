// Task 2

Console.Clear();
Console.WriteLine("Введите 2 числа и мы скажем, какое из них больше");
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{Console.WriteLine("Второе число больше первого ");

}
else if (a > b)
{Console.WriteLine("Первое число больше второго");  

}
else if (a == b)
{Console.WriteLine("Оба числа равны");  

}
