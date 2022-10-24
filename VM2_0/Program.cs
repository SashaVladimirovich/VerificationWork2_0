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
string PrintText(string[] text)
{
    return String.Join(' ', text);
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
int wordCount = new Random().Next(2, 30);
string[] text = new string[wordCount];
text = FillText(text, wordCount);
Console.WriteLine(PrintText(text));
Console.WriteLine();
string newText = DelWord(text);
Console.WriteLine($"{newText}");


