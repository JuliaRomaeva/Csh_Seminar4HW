// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());

int Sum(int n){
    int sum = 0;
        while (n > 0){ 
        sum = n  % 10 + sum; 
        n /= 10;
        }
    return sum;
}
int result = Sum(num);
Console.WriteLine($"{num} -> {result}");
