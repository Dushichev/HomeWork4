/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16*/

Console.WriteLine("введите число A");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B");
int numB = int.Parse(Console.ReadLine());

/*double result = Math.Pow(a, b);
Console.WriteLine(result);*/

int result = 1;
for (int i = 0; i < numB; i++)
{
    result = result * numA;
}

Console.WriteLine(result);
