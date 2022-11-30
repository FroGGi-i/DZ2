//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}

//Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    while (n > 1000)
        n = n / 10;

    Console.WriteLine(n % 10);
}

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("\n Введите номер дня недели  "); 
int num = int.Parse(Console.ReadLine()); 
if (num >= 1 && num <= 5) 
{ 
Console.Write("Нет"); 
} 
 
else if (num >= 6 && num <= 7) 
{ 
Console.Write("Да"); 
} 
else Console.Write(" Не существует такого дня недели");