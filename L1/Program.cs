/* Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B. */

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

double NumPower(double powerbase, int exp)
{
    int i = 1;                                        // Создаем счетчик цикла
    bool sign = false;                                // Логическая переменная для хранения знака числа В. false положит., true отрицат.
    double pow = 1;                                     
    if (exp < 0)                                      // Проверяем знак показателя степени 
    {
        sign = true;
        exp = -exp;
    }
    while (i <= exp)                                  // Цикл для вычисления значения  
    {
        pow = pow * powerbase;
        i++;
    }
    if (sign)                                         // Вычисляем значение, если степень меньше нуля  
    {
        pow = 1 / pow;
    }
    return pow;
}
int numA = Prompt("Введите число А ");
int numB = Prompt("Введите число B ");
System.Console.WriteLine($"Число {numA} в степени {numB} равно {NumPower(numA, numB)}");