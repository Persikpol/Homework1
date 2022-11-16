// Task 2
Console.WriteLine("Введите 1ое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2ое число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1<number2)
{
    Console.WriteLine("Большее число " + number2);
}
else
{
    Console.WriteLine("Большее число " + number1);
}
