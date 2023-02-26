// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень:");
int B = int.Parse(Console.ReadLine());

int Method(int a, int b){
    int result = 1;
    for(int i = 0; i < b; i++){
        result *= a;
    }
    return result;
}
int res = Method(A,B);
Console.WriteLine($"{A},{B} -> {res}");