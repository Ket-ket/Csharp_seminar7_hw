// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Например:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadInt(string text){
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNaturalNumbers(int start, int end)
    {
        if (start > end) return;
        Console.Write(start + " ", end);
        PrintNaturalNumbers(start + 1, end);
    }

int M = ReadInt("Введите значение M: ");
int N = ReadInt("Введите значение N: ");
Console.WriteLine($"Натуральные числа от {M} до {N}:");
PrintNaturalNumbers(M, N);
