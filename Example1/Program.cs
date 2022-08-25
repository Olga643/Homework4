// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine ("Ведите число A");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine ("Ведите число B");
int numberB = int.Parse(Console.ReadLine() ?? "0");

if ( numberA == numberB * numberB)
{
   Console.WriteLine ("Число А это квадрат числа B"); 
}
else
{
   Console.WriteLine ("Число А это не квадрат числа B"); 
}


