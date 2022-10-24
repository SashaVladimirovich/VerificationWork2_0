﻿Console.Clear(); 
string[] FillText(string[] text, int wordCount) 
{ 
    string librarySymbol = "-:;()*&^%$#@!0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"; 
 
    for (int i = 0; i < wordCount; i++) 
    { 
        string word = String.Empty; 
        int wordLength = new Random().Next(1, 15); 
        for (int j = 0; j < wordLength; j++) 
        { 
            word = word + librarySymbol[new Random().Next(0, 75)]; 
        } 
        text[i] = word; 
    } 
    return text; 
} 
string PrintText(string[] text) 
{ 
    return  String.Join(' ', text); 
} 
string DelWord(string[] text) 
{ 
    string newText = string.Empty; 
    for (int index = 0; index < text.Length; index++) 
    { 
        string newWord = text[index]; 
        if (newWord.Length <= 3) 
        { 
            newText += newWord + " "; 
        } 
 
    } 
    return newText; 
} 
 
Console.WriteLine("Здравствуйте. Данная программа удаляет из текста слова, длина которых более 3х символов"); 
Console.WriteLine("Введите в консоли текст и нажмите клавишу Enter"); 
Console.WriteLine("Программа может сгенерировать текст автоматически. Для этого необходимо нажать клавишу Enter не заполняя поле ввода"); 
Console.WriteLine(); 
 
string enter = Console.ReadLine(); 
if (enter == String.Empty) 
{ 
    int wordCount = new Random().Next(2, 30); 
    string[] text = new string[wordCount]; 
    text = FillText(text, wordCount); 
    Console.WriteLine(PrintText(text)); 
    Console.WriteLine(); 
    string newText = DelWord(text); 
    Console.WriteLine($"{newText}"); 
} 
else 
{ 
    Console.WriteLine(); 
    string[] text = enter.Split(' '); 
    string newText = DelWord(text); 
    Console.WriteLine($"{newText}"); 
}

