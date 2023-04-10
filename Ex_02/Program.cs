Console.Write("Введите целое число №1: ");
string UserNamber1 = Console.ReadLine() ?? "";
int namber_a = int.Parse(UserNamber1);

Console.Write("Введите целое число №2: ");
string UserNamber2 = Console.ReadLine() ?? "";
int namber_b = int.Parse(UserNamber2);

Console.Write("Введите целое число №3: ");
string UserNamber3 = Console.ReadLine() ?? "";
int namber_c = int.Parse(UserNamber3);

int max = namber_a;

if (namber_a > max) max = namber_a;
if (namber_b > max) max = namber_b;
if (namber_c > max) max = namber_c;

Console.Write($"Max Namber = {max}");
