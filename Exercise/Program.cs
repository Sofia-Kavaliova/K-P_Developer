// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 


﻿string[] array1 = new string[5] {"1234", "1567", "-2", "computer science"};
string[] array2 = new string[array1.Length];
SecondArrayWithIF(array1, array2);
PrintArray(array2);
