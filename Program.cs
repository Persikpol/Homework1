// Task 8
Console.WriteLine("Введите число больше 0");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i<=number)
{
    if (i%2 == 0)
    {
        Console.WriteLine(i);
        i++;
    }
    else
    {
        i++;
    }
}