//Показать четные числа от 1 до N

Console.WriteLine ("Введите чиcло N");
int N = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i <= N; i++) 

{
    if (i % 2 == 0)
    {
         Console.WriteLine (i + " "); 
    }
}
Console.WriteLine();
