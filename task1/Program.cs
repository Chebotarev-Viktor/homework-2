int number = new Random().Next(100, 1000);

Console.WriteLine(number);

Console.WriteLine($"вторая цифра числа {number} будет {number / 10 % 10}");