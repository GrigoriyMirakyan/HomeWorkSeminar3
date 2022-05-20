/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/

int GetNumber(string msg) //функция считывающая введенное число + проверка что число является числом)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;

        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

double GetLengthVector(double x1, double x2, double y1, double y2, double z1, double z2) // Функция принимающая координаты точек(x1,x2,y1,y2,z1,z2) и высчитывающая расстояние 

{
    double difx = Math.Pow((x1 - x2), 2);
    double dify = Math.Pow((y1 - y2), 2);
    double difz = Math.Pow((z1 - z2), 2);
    double length = Math.Sqrt(difx + dify + difz);
    return length;

}

int x1 = GetNumber("введите координату первой точки по оси x");
int y1 = GetNumber("введите координату первой точки по оси y");
int z1 = GetNumber("введите координату первой точки по оси z");
int x2 = GetNumber("введите координату второй точки по оси x"); /*   получаем координаты точек с помощью функции GetNumber  */
int y2 = GetNumber("введите координату второй точки по оси y");
int z2 = GetNumber("введите координату второй точки по оси z");

double result = GetLengthVector(x1, x2, y1, y2, z1, z2);             /* вызов функции GetLenghtVector и передача ей координат (x1,x2,y1,y2,z1,z2) */

Console.WriteLine($"Расстояние между точками равно   {result}");

