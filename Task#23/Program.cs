//Принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
double num = double.Parse(Console.ReadLine());
double i = 1; 
Console.WriteLine("Ответ: ");
while (i <= num)
{
    double resoult = Math.Pow (i, 3);
    Console.Write(resoult + ",");
    i++;
}
