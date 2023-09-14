// Задача полиндром
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a / 10000;
int a2 = a / 1000 % 10;
int a3 = a / 10 % 10;
int a4 = a % 10;
if (a1 == a4 && a2 == a3)
  Console.WriteLine("yes");
else
  Console.WriteLine("no");
