using Task1;
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
    else if (IsNumbers(input))
    {
        Console.WriteLine("Строка содержит цифры");
    }
    else if (choise != "1" && choise != "2")
    {
        Console.WriteLine("Введён не верный вариант");
    }
    else
    {
        if (choise == "1")
        {
            Console.WriteLine(Encryption(input, key));
        }
        if (choise == "2")
        {
            Console.WriteLine(Decipher(input, key));
        }
    }
}
static bool IsNumbers(string input)
{
    bool result = false;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] >= '0' && input[i] <= '9')
        {
            result = true;

        }
    }
    return result;
}

static string Encryption(string input, int key)
{
    string output = string.Empty;

    foreach (char letter in input)
    {
        if (input[0] >= 'a' && 'z' <= input[0])
        {
            output += RussianCipher(letter, key);

        }
        else
        {
            output += EnglishCipher(letter, key);
        }
    }

    return output;
}
static char EnglishCipher(char letter, int key)
{
    if (!char.IsLetter(letter))
    {

        return letter;
    }
    char upperModifier = char.IsUpper(letter) ? 'A' : 'a';
    return (char)((((letter + key) - upperModifier) % 26) + upperModifier);
}
static char RussianCipher(char letter, int key)
{
    if (!char.IsLetter(letter))
    {

        return letter;
    }
    char upperModifier = char.IsUpper(letter) ? 'А' : 'а';
    return (char)((((letter + key) - upperModifier) % 32) + upperModifier);
}
static string Decipher(string input, int key)
{
    int languageMadifier;
    if (input[0] >= 'a' && 'z' <= input[0])
    {
        languageMadifier = 32;
    }
    else
    {
        languageMadifier = 26;
    }
    return Encryption(input, languageMadifier - key);
}



