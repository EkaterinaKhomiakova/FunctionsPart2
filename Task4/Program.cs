// Напишите программу, которая принимает на вход число A
// и выдает сумму чисел от 1 до A
// 7->28
// 4->10
// 8->36
double f(double x)
{
  return ((1 + x) / 2 * x);
}

double a = Convert.ToDouble(Console.ReadLine());
Console.Write(f(a));