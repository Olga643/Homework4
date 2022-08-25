// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число");

int N = int.Parse(Console.ReadLine() ?? "0");

 if ( N > 99 )
{
  Console.WriteLine(N.ToString()[2]);
}
else
{
  Console.Write("В этом числе нет третьей цифры");
}