// Удалить вторую цифру трёхзначного числа

Console.WriteLine ("Введите трехзначное число");

int N = int.Parse(Console.ReadLine() ?? "0");

if ( N < 100 ^ N > 999) 
{
    Console. WriteLine ("Ошибка ввода. Ввведите ТРЕХЗНАЧНОЕ число!!!"); 
}
else
{
    int N1 = N / 100 * 10 + N % 10;
    Console.Write(N1); 
}


