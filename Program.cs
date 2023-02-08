// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Здесь еще можно дописать проверку на то, является ли число 5значным, но такая задача не ставилась.

bool isPalindrom(int n)
  {
    bool result = false;
    int a=0, b=n;
    while (n>0)
      {
        a = a * 10 + n % 10;
        n = n / 10;
      }
    if(a == b) 
        result = true;
    return result;
  }
  
Console.Write("Input a 5-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isPalindrom(number));

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double LineLenght(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double lenght1 = x2 - x1;
    double lenght2 = y2 - y1;
    double lenght3 = z2 - z1;
    double result = Math.Sqrt(Math.Pow(lenght1,2) + Math.Pow(lenght2,2)+ Math.Pow(lenght3,2));
    return result;
}
Console.Write("Input X for the 1st point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y for the 1st point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z for the 1st point: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X for the 2nd point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y for the 2nd point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z for the 2nd point: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Lenght of the line is " + Math.Round(LineLenght(x1, y1, z1, x2, y2, z2),2));

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++) Console.Write($"{Math.Pow(i, 3)}, ");
Console.WriteLine(" ");
