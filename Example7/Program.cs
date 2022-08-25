// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a = new Random().Next(10,99);
Console.WriteLine (a); 

int a1 = a / 10;
int a2 = a % 10;
int max = a1;

if (a2 > max) max = a2;


Console.Write ("max = ");
Console.WriteLine (max);
