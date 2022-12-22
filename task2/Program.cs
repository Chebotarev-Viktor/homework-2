int number = int.Parse(Console.ReadLine()!);

if(number<0)
{
    number = -number;
}

if(number<100)
{
    Console.WriteLine("некоректное число");
}
else
{
    while (number <= 999);
{
    number = number / 10;
}
int thierdDigit = number % 10;

    Console.WriteLine(thierdDigit);
}