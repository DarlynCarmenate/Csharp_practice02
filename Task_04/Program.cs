Console.WriteLine("Введите цифу от 1 до 7: ");
string first = Console.ReadLine();
int a = int.Parse(first);

if(a == 6 | a == 7)
{
    Console.WriteLine("Это выходной день");
}
if(a < 6)
{
    Console.WriteLine("Это рабочий день");
}