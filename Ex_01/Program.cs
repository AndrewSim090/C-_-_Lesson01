Console.Write("Введите целое число №1: ");
string UserNamber1 = Console.ReadLine() ?? "";
int namber_a = int.Parse(UserNamber1);

Console.Write("Введите целое число №2: ");
string UserNamber2 = Console.ReadLine() ?? "";
int namber_b = int.Parse(UserNamber2);

if (namber_a > namber_b)
{
    Console.Write($"Max Namber = {namber_a}, Min Namber = {namber_b}.");
}
else
{
    Console.Write($"Max Namber = {namber_b}, Min Namber = {namber_a}.");
}