// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int SumDigits(int number)                              // Функция считает сумму цифр в числе 
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

int number = Prompt("Введите число ");
System.Console.WriteLine($"Сумма цифр числа {number} равна {SumDigits(number)}");