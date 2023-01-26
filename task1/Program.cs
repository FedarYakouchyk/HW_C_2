Random rand = new Random();
int randNum = rand.Next(100, 1000);
System.Console.WriteLine($"Выпало число: {randNum}");
int secondNum = (randNum%100)/10;
System.Console.WriteLine($"Вторая цифра данного числа - {secondNum}");

////////////////////////////////












