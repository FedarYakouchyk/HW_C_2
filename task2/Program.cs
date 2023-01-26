// Первый метод
Console.Write("Введите любое 9-ти значное число: ");
string num = Console.ReadLine();
int size = num.Length;
int N = Convert.ToInt32(num);
System.Console.WriteLine($"Отлично, вы ввели {size} значное число");
if (size<3)
{
    Console.WriteLine("Введённое вами число не является 3-х значным! Попробуйте снова!");
}
while (size>=3)
{
  if (size != 3)
  {
         size = size-1;
    N= N/10;
    
  }  
  else
  {
    size = size-1;
    N= N%10;
  }
}
System.Console.WriteLine($"Третья цифра вашего числа - {N}");

//////// Второй вариант/////


Console.Write("Введите любое 9-ти значное число: ");
string num1 = Console.ReadLine();
int size1 = Convert.ToInt32(num1.Length);
if (size1>=3)
{
   int rez =num1[2];
    System.Console.WriteLine($"Третья цифра введённого числа - {num1[2]}"); //Подскажите, пожалуйста.
    //Если сюда вкладываю переменную rez выдаёт какие то левые цифры (даже после конвертации)
}
else
{
    Console.WriteLine("Введённое вами число не является 3-х значным! Попробуйте снова!");
}

