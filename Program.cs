    /*Задача 19
    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
    14212 -> нет
    12821 -> да
    23432 -> да
    */


    /*Задача 21
    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.8
    A (7,-5, 0); B (1,-1,9) -> 11.53
    */


double getDistance(double xa, double ya, double ia, double xb, double yb, double ib) {
    return Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (ib -ia) * (ib - ia));
}
Console.Write("Введите координату Х первой точки: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату i первой точки: ");
double ia = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Х второй точки: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату i второй точки: ");
double ib = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками: " + Math.Round(getDistance( xa, ya, ia, xb, yb, ib),1));


    /*Задача 23
    Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
    */

void squareTable(int n) {
    int currentNumber = 1;
    while (currentNumber <= n)
    {
         Console.WriteLine(currentNumber + "-" + (currentNumber * currentNumber * currentNumber));
         currentNumber++;
    }
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 0)
    squareTable(n);
else
Console.Write("Введите число больше 0");

