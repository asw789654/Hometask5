using Task1;
const int russianAlphabetLenght = 32;
const int englishAlphabetLenght = 26;
while (true)
{
    Console.Write("Введите ключ: ");
    int key = NumberCheck.AskForNumber("число");
    Console.Write("Введите строку: ");
    string input = Console.ReadLine();
    Console.WriteLine($"1.Зашифровать{Environment.NewLine}2.Расшифровать ");
    string choise = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Строка пуста");
    }
    else if (choise != "1" && choise != "2")
    {
        Console.WriteLine("Введён не верный вариант");
    }
    else
    {
        bool cryption = false;
        if (choise == "1")
        {
            cryption = true;
        }
        Console.WriteLine(Сryption(input, key, cryption));
    }
}

static string Сryption(string input, int key, bool cryption)
{
    string output = string.Empty;
    foreach (char letter in input)
    {
        if (letter >= 'a' && letter <= 'z')
        {
            output += EnglishCipher(letter, key, cryption);
        }
        else
        {
            output += RussianCipher(letter, key, cryption);
        }
    }

    return output;
}

static char EnglishCipher(char letter, int key, bool cryption)
{
    if (!cryption)
    {
        key = englishAlphabetLenght - key;
    }
    if (!char.IsLetter(letter))
    {
        return letter;
    }
    char upperModifier = char.IsUpper(letter) ? 'A' : 'a';
    return (char)((((letter + key) - upperModifier) % englishAlphabetLenght) + upperModifier);
}

static char RussianCipher(char letter, int key, bool cryption)
{
    if (!cryption)
    {
        key = russianAlphabetLenght - key;
    }
    if (!char.IsLetter(letter))
    {
        return letter;
    }
    char upperModifier = char.IsUpper(letter) ? 'А' : 'а';
    return (char)((((letter + key) - upperModifier) % russianAlphabetLenght) + upperModifier);
}
