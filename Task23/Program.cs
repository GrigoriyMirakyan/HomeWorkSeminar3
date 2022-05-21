/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

int GetNumber() //функция считывающая введенное число + проверка что число является числом
{
    while (true)
    {
        Console.WriteLine("Введите число: ");
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            if (number == 0 || number < 0)
                Console.WriteLine("Введите число, отличное и  болшее чем ноль");
            else
                return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

void Calculation(int number)
{
    int i = 1;
    double result;
    while (i < number || i == number)
    {
        result = Math.Pow(i, 3);
        Console.Write($"{result}, ");
        i++;
    }

}

int number = GetNumber();
Calculation(number);




