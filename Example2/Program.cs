// По заданному номеру дня недели вывести его название

Console.WriteLine ("Ведите число от 1 до 7");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number == 1) Console.WriteLine ("Monday");
if (number == 2) Console.WriteLine ("Tuesday");
if (number == 3) Console.WriteLine ("Wednesday");
if (number == 4) Console.WriteLine ("Thursday");
if (number == 5) Console.WriteLine ("HALLELUJAH! FRIDAY!");
if (number == 6) Console.WriteLine ("Saturday");
if (number == 7) Console.WriteLine ("Sunday");