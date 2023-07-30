/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Если решаете математически через рандом, то проверка не нужна на трехзначность. Если через строки, то она обязательна)
456 -> 5
782 -> 8
918 -> 1 */

/* Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

string NewStr = num.ToString();
if (NewStr.Length == 3) 
{
    Console.WriteLine ($"Вторая цифра числа {num} имеет вид {NewStr[1]}");
}
else
{
     Console.WriteLine ($"Число {num} не трехзначное"); 
} */







/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Если решаете математически максимум берем 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* Console.WriteLine ("Введите число: ");
int num =  int.Parse(Console.ReadLine());
string New_num = num.ToString();
if (New_num.Length >= 3) 
{
    Console.WriteLine ($"Третья цифра числа {num} имеет вид {New_num[2]}");
}
else
{
    Console.WriteLine ("Третьей цифры нет");
} */





/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
(Проверка выхода за пределы значений недели, т.е. < 1 и > 7)
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите цифру: ");
int num =  int.Parse(Console.ReadLine());
if (num == 1)
{
    //Console.WriteLine("Понедельник");
    Console.WriteLine("Нет");
}

if (num == 2)
{
    //Console.WriteLine("Вторник");
    Console.WriteLine("Нет");
}

if (num == 3)
{
    //Console.WriteLine("Среда");
    Console.WriteLine("Нет");
}

if (num == 4)
{
    //Console.WriteLine("Четверг");
    Console.WriteLine("Нет");
}

if (num == 5)
{
    //Console.WriteLine("Пятница");
    Console.WriteLine("Нет");
}

if (num == 6)
{
    //Console.WriteLine("Суббота");
    Console.WriteLine("Да");
}

if (num == 7)
{
    //Console.WriteLine("Воскресенье");
    Console.WriteLine("Да");
}

if (num > 7)
{
   
    Console.WriteLine("Выход за пределы допустимых значений");
}

if (num < 1)
{
   
    Console.WriteLine("Выход за пределы допустимых значений");
}