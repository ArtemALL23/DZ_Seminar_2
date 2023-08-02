/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());

if (first > second){
    Console.Write($"max = {first}");
}

else Console.Write($"max ={second}"); */




/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 


Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int third = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Max(Math.Max(first, second), third)); */



/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет 

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

if (A%2 == 0){
    Console.Write("Да");
}
else Console.Write("нет"); */



/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

for (int i = 1; i <= A; i++){
    if(i%2 == 0){
        Console.Write($"{i}  ");
    }
}

