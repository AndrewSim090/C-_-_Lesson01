Console.Write("Введите целое число: ");
string UserNamber1 = Console.ReadLine() ?? "";
int namber_a = int.Parse(UserNamber1);

int count = 2;

while (count <= namber_a)
{
    Console.WriteLine(count);
    count = count + 2;
}