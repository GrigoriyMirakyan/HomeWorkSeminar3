/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

int GetNumber() //функция считывающая введенное число + проверка что число является числом 
{
    while (true)
    {
        Console.WriteLine("Введите число: ");
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



int FillArray(int[] collection) //метод, заполняющий массив таблицей кубов от 1 до N
{
    int number = collection.Length;
    int index = 1;
    if (index < number)
    {
        collection[index] = new Math.Pow((index), 3);
        index++;
    }
    else
    {
        Console.WriteLine(collection);
    }
}
int number = GetNumber;
FillArray(number);

