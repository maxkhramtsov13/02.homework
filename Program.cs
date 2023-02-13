//Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Write($"Введите первое число -> ");
		int a = Convert.ToInt32(Console.ReadLine());

		Console.Write($"Введите второе число -> ");
		int b = Convert.ToInt32(Console.ReadLine());

		int max = a;
		int min = a;

		if (a > max) max = a;
		if (b < max) min = b;
		if (b > max) max = b;
		if (a < max) min = a;

		Console.Write($"Mаксимальное число -> ");
		Console.WriteLine(max);

		Console.Write($"Mинимальное число -> ");
		Console.WriteLine(min);
	}
}