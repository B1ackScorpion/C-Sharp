﻿// Задача 2.
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.Clear();
Console.WriteLine("Введите строку из символов в верхнем и нижнем регистрах");
string str = Console.ReadLine()!;
Console.WriteLine(str.ToLower());