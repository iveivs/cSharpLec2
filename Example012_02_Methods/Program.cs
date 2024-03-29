﻿// ==== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого "
            + "Винценгероде, вы бы взяли приступом согласие"
            + "прусского короля. Вы так красноречивы. Вы "
            + "дадите мне чаю? ";

// string s = "qwerty"
//             0123
// s[3] // r 
 
string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty; // Инициализация пустой строки

    int length = text.Length;      // Получаем длину нашей строки
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|' );
Console.WriteLine(newText);