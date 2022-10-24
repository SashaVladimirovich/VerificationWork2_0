Console.Clear(); 
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