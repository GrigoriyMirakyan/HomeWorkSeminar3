/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

string GetNumber() // функция принимает число и проверяет является ли оно пятизначным и число ли вообще
{
    while (true)
    {
        Console.WriteLine("Введите пятизначное число:");
        string getNumber = Console.ReadLine();

        if (int.TryParse(getNumber, out int number))
        {
            if (getNumber.Length == 5)
                return getNumber;
            else
            {
                Console.WriteLine("Число должно быть пятизначным. Введите другое число");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести пятизначное число");
        }
    }
}

void Palindrom(string getNumber) /* Метод принимает строку из функции GetNumber и проверяеет является ли палиндромом*/
{
    if (getNumber[0] == getNumber[4] && getNumber[1] == getNumber[3]) Console.WriteLine($"{getNumber} -> Да");
    else Console.WriteLine($"{getNumber} -> Нет");
}

string getNumber = GetNumber();
Palindrom(getNumber);