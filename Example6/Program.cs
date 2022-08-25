// Показать вторую цифру трёхзначного числа

Console.WriteLine ("Введите трехзначное число");

int N = int.Parse(Console.ReadLine() ?? "0");
int N1 =(N / 10) % 10;

Console. Write (N1);