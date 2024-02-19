// //Задача 1

void ShowNumbers (int start, int end)
{
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + " ");
    ShowNumbers(start + 1, end);
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

ShowNumbers(M, N);

// Задача 2

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

int CalculateAckermannFunction (int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return CalculateAckermannFunction(n - 1, 1);
    }
    else
    {
        return CalculateAckermannFunction(n - 1, CalculateAckermannFunction(n, m - 1));
    }
}

Console.WriteLine($"Результат вычисления функции Аккермана равен {CalculateAckermannFunction(M, N)}");



// Задача 3

int[] arbitraryArray = {4, 5, 11, 89, 1, 9, 12, 6};
int arrayLength = arbitraryArray.Length;
 
void PrintReverseArray (int[] array, int j)
{
    if(j == 0)
    {
        return;
    }

    Console.Write(array[j - 1] + " ");
    PrintReverseArray(array, j - 1);
}

PrintReverseArray(arbitraryArray, arrayLength);