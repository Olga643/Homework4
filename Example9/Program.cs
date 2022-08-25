// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int a = new Random().Next(1,100);
Console.WriteLine (a);
int b = 6;

if (a % b == 0) 
{
    Console.WriteLine ("Выбранное число кратно 6");
}    
else
{
   Console.WriteLine ( a % b); 
}
