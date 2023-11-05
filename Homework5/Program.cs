using Task1;

int[,] numbers;
int lenth;
bool isRightArray = true;

while (isRightArray)
{
    Console.Write("Введите размерность массива: ");
    lenth = NumberCheck.AskForNumber("число");
    if (lenth > 1)
    {
        int diagonalSum = 0, underDiagonalSum = 0;
        Console.WriteLine("Заполните массив");
        numbers = new int[lenth, lenth];
        isRightArray = false;
        for (int i = 0; i < lenth; i++)
        {
            for (int j = 0; j < lenth; j++)
            {
                Console.Write($"Число {i + 1}{j + 1}:");
                numbers[i, j] = NumberCheck.AskForNumber("число");
            }
        }

        for (int i = 0, j = lenth - 1; i < lenth; i++, j--)
        {
            diagonalSum += numbers[i, j];
        }

        for (int i = 1; i < lenth; i++)
        {
            for (int j = lenth - i; j < lenth; j++)
            {
                underDiagonalSum += numbers[i, j];
            }

        }
        Console.WriteLine($"Сумма значений побочной диагонали: {diagonalSum}");
        Console.WriteLine($"Сумма значений под побочной диагональю: {underDiagonalSum}");

    }
    else
    {
        Console.WriteLine("Неверная размерность массива\n");
    }
}
