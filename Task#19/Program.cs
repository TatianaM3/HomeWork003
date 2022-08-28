// Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Console.WriteLine("Введите пятизначное число: ");
//string str = Console.ReadLine();
//while (str. Length < 5 || str. Length > 5)
//{
//    Console.WriteLine("Введите пятизначное число: ");
//    str = Console.ReadLine();
//}
//if (str[0] == str[4] && str[1] == str[3])
//{
//    Console.WriteLine("палиндром");
//}
//else
//{
//    Console.WriteLine("не палиндром");
//}

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse (Console.ReadLine());
while (num < 10000  || num > 99999) 
{
    Console.WriteLine("Введите пятизначное число: ");
    num = int.Parse (Console.ReadLine());
}
int num1 = num / 10000;
int num2 = num % 10;
int num3 = (num/1000)%10;
int num4 = (num % 100)/10;
if (num1 == num2 && num3 == num4)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}