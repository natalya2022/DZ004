﻿/* Напишите программу, которая задаёт массив из 8 элементов случайными числами
и выводит их на экран. Также ищет второй максимум (число меньше максимального
элемента, но больше всех остальных) Оформите заполнение массива и вывод в виде
функции (пригодится в следующих задачах) */

int[] ArrayGeneration(int leng, int maxRand = 20, int minRand = 0) //Функция генерации массива по заданным условиям
{
    int[] myArr = new int[leng];
    int i = 0;
    while (i < myArr.Length)
    {
        myArr[i] = new Random().Next(minRand, maxRand);
        i++;
    }
    return myArr;                                       // Возвращаем массив
}

void ArrayPrint(int[] myArr)                            // Функция печати массива    
{
    for (int j = 0; j < myArr.Length; j++)
    {
        System.Console.Write($"{myArr[j]}  ");
    }
}

/* Условие задачи подразумевает нахождение элемента, меньшего, чем максимальный, но
большего, чем остальные. В случае, если в массиве будут несколько первых, подряд идущих элементов
равных max1, функция будет их пропускать и брать следующий по уменьшению. Пример: 9 9 8 7, первый максимум
равен 9, второй 8. Для этого введен второй цикл.
*/

int ArrayMax(int[] myArr)                  // Функция для нахождения второго максимума
{
    int k = 0;                             // Находим первый максимум 
    int max1 = myArr[k];
    while (k < myArr.Length)
    {
        if (myArr[k] > max1)
        {
            max1 = myArr[k];
        }
        k++;
    }                                       // Нашли первый максимум

    bool secondmaxpresent = false;          // Флаг наличия второго максимума
    k = 0;
    while (k < myArr.Length)                // Цикл определяет наличие второго максимума
    {
        if (myArr[k] < max1)                // Находим первое по порядку значение меньше max1
        {
            secondmaxpresent = true;        // Значение найдено, второй максимум существует, ставим флаг
            break;                          // Выходим из цикла    
        }
        k++;
    }
    if (secondmaxpresent == false)          // Если второго максимума нет, формируем исключение, выходим из функции
    {
        throw new Exception("Второго максимума нет");
    }

    int max2 = myArr[k];                     // Цикл для поиска второго максимума   
    k = 0;
    while (k < myArr.Length)
    {
        if (myArr[k] > max2 && myArr[k] < max1)
        {
            max2 = myArr[k];
        }
        k++;
    }
    return max2;                             // Вернули значение второго максимума
}

int[] array = ArrayGeneration(8, 10);        // Вводим параметры массива (8 элементов в диапазоне от 0 до 10)
ArrayPrint(array);                           // Печатаем массив   
System.Console.WriteLine();
System.Console.WriteLine($"Второй максимум равен {ArrayMax(array)}");   //Выводим второй максимум