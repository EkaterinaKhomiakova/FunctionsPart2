// Напишите прогамму, которая принимает на вход число
// и выдает колличество цифр в числе
// 456->3
// 78->2
// 89126->5
int f(int a)
{
  if (a == 0)
    return 1;
  int count = 0;
  while (a > 0)
  {
    a /= 10;
    count++;
  }
  return count;
}
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a));