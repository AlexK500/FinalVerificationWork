﻿// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// создание нового массива из строк 
string[] arrString = { "Hello", "2", "world", ":-)" };
int i = 0;
// считаем сколько элементов в массиве, длина которых меньше, либо равна 3 символам. 
int cnt = 0;
string[] Array(string[] arr)
{
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            cnt++;

        }
    }
    // объявляем новый массив с уже известной длиной
    string[] newArr = new string[cnt];
    int tmp = 0;
    // наполняем массив строковыми элементами, где длина которых меньше, либо равна 3 симыолам
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[tmp] = arr[i];
            tmp++;
        }
    }
    return newArr;
}

// Выводим результат
Console.WriteLine();
Console.Write("["+String.Join(", ", arrString)+"] ");
Console.WriteLine(" -> ["+String.Join(", ", Array(arrString))+"]");
Console.WriteLine();