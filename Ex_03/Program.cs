Console.Write("Введите целое число: ");
string UserNamber1 = Console.ReadLine() ?? "";
int namber_a = int.Parse(UserNamber1);

if (namber_a % 2 == 0)
{
    Console.Write("четное");
}
else
{
    Console.Write("не четное");
}