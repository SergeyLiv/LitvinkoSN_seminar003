// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int N = Convert.ToInt32(Console.ReadLine());
if (N / 10000 == N % 10 && N / 1000 % 10 == N % 100 / 10)
    Console.WriteLine("Данное число является палиндромом");  
else
    Console.WriteLine("Данное число НЕ является палиндромом");