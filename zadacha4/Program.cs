//на вход принимает три числа и выдаёт,
//какое число большее.
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Max of three values {0} {1} {2}  = {3}", 
num1, num2, num3, Math.Max(num1, Math.Max(num2, num3)));
            Console.ReadKey();