//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int a = number1;

for (int i = 1; i < number2; i++)
{
    number1 =  number1 * a;
}
Console.WriteLine(number1);
Console.ReadLine();
*/

//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number >= 1)
{
    sum += number % 10;
    number = (number - number % 10) / 10;
}

Console.WriteLine(sum.ToString());
*/

//Задача 3:  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] good = new[]{1, 2, 5, 7, 19, 6, 8, 11};
foreach (var item in good)
{
    Console.Write(item);
}
*/










