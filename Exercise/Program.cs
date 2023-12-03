// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}


﻿string[] array1 = new string[5] {"1234", "1567", "-2", "computer science"};
string[] array2 = new string[array1.Length];
SecondArray(array1, array2);
PrintArray(array2);
