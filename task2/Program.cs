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