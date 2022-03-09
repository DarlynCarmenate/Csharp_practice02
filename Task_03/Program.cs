Console.WriteLine("Введите число: ");
string first = Console.ReadLine();
int a = int.Parse(first);

if(a < 100)
{
    Console.WriteLine("Третьей цифры не существует");
}
else
{
    while(a > 999)
    {
        a = a / 10;
    }
    int result = a % 10;
    Console.WriteLine($"Третья цифра: {result}");
}