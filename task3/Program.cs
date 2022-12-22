Console.WriteLine("введите число");
string input = Console.ReadLine()!;

int a = int.Parse(input);


if (a < 6)
{
   Console.WriteLine("не является выходным");
}
else if (a == 6)
{
   Console.WriteLine("выходной день");
}
else if (a == 7)
{
   Console.WriteLine("выходной день");
}
else if (a > 7)
{
   Console.WriteLine("некоректное число");
}



