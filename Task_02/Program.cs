int a = new Random().Next(100,1000);
int third = a % 10;
int first = a / 100;
Console.WriteLine("Получает на вход " + a);
Console.WriteLine("Отдает " + first + third);

