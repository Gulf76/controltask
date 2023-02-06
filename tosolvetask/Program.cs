/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых 
меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения 
алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


//                 //  ВАРИАНТ 1

// string[] array =
// {"Hello", "2", "world", ":-)","1234", "1567", "-2", "computer science","Russia", "Denmark", "Kazan"
// };
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
// Console.Write($"Текущий  массив: ");
// for (int i = 0; i < array.Length; i++)
// {
//     string? n = array[i];
//     if (n.Length <= 3)
//     Console.Write($" {array[i]}");
// }


//                     //ВАРИАНТ 2

// void InputArray(string[] array)

// {
//     for (int i = 0; i < array.Length; i++)

//     {
//         Console.Write("Введите элемент  ");
//         string? x = Console.ReadLine();
//         array[i] = x;
//     }
// }

// void ReleaseArray(string[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         string? n = array[i];
//         if (n.Length <= 3)
//             Console.Write($" {array[i]}");

//     }

// }
// Console.Clear();
// Console.WriteLine("Напишите количество элементов массива  ");
// int m = Convert.ToInt32(Console.ReadLine());
// string[] array = new string[m];
// InputArray(array);
// Console.Write($"Исходный массив:[{string.Join(",", array)}]");
// Console.WriteLine();
// Console.Write("Текущий массив:");
// ReleaseArray(array);

