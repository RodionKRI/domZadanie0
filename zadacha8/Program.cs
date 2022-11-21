//выводит все четные числа 
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
{    
for (int i = 1; i <= num1; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);
}        