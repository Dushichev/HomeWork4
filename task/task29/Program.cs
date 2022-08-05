/*задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33-> [6, 1, 33]*/


/*int[] myArray = new int[8];
Random random = new Random();


for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next(8);

    Console.Write(myArray[i] + " ");
}*/

Console.WriteLine("Введите длинну массива");

int elementArray = int.Parse(Console.ReadLine());

int[] myArray = new int[elementArray];


for (int i = 0; i < myArray.Length; i++)
{
    Console.Write("Введите элемент массива" + " ");
    myArray[i] = int.Parse(Console.ReadLine());


}
Console.WriteLine("Массив");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}

