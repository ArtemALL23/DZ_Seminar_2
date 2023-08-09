/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое == последнему, второе == предпоследнему).
14212 -> нет
12821 -> да
23432 -> да */


/* Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
string number = num.ToString();

if (number.Length == 5){
    if (number[0]==number[4] && number[1]=number[3]) Console.WriteLine("Это число полиндром.");
    else Console.WriteLine("Это число не полиндром.");
}
else Console.WriteLine("Введено не пятизначное число"); */





/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

 /* Console.WriteLine("Введите первую координату x");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую координату y");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третью координату Z");
            int z1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите первую координату x2");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую координату y2");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третью координату Z2");
            int z2 = int.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine(distance);

            Console.ReadKey();




/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 

Console.Writline ("Введите число: ");
int num = int.Parse(Console.ReadLine());
int index = 1;
While (index <= num)
{
    Console.WritLine(Math.Pow(index, 3));
    index++;
}*/



