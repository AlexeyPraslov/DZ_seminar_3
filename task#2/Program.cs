﻿// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.


System.Console.WriteLine("Введите размер массива: "); //запрос ввода длинны массива
int size = Convert.ToInt32(Console.ReadLine());//приводим полученные данные от пользователя к числовому значению

Random random = new Random();//создали генератор случайных чисел

int[] array = new int[size];// Создаем массив

for (int i = 0; i < size; i++)// Заполняем массив случайными целыми числами от 1 до 100
{
    array[i] = random.Next(10);
}
Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");// Выводим массив


int numbers = 0;// Находим количество чётных чисел в массиве с использованием цикла for

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        numbers++;
    }
}
Console.WriteLine("Количество чётных чисел в массиве: " + numbers);// Выводим результат
