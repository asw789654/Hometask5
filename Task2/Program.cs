using System.Text;

while (true)
{
    string input, output;
    const char replacement = 'H';
    Console.Write("Введите строку: ");
    input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Строка пуста");
    }
    else if (input.IndexOf('h') == -1)
    {
        Console.WriteLine("В строке не символа h");
    }
    else
    {
        StringBuilder inputStringBuilder = new StringBuilder(input);
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'h' && i != input.IndexOf('h') && i != input.LastIndexOf('h'))
            {
                inputStringBuilder[i] = replacement;
            }
        }
        output = inputStringBuilder.ToString();
        Console.WriteLine(output);
        break;
    }

}


