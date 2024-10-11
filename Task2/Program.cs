// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Например:
// m = 2, n = 3 -> A(m,n) = 29

int ReadInt(string text){
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermannFunction(int M, int N){
    if (M == 0){
        return N + 1;
    } else if (M > 0 && N == 0){
        return AckermannFunction(M - 1, 1);
    } else if (M > 0 && N > 0){
        return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
    } else 
        return 0; 
}

int M = ReadInt("Введите значение M: ");
int N = ReadInt("Введите значение N: ");
int result = AckermannFunction(M, N);
Console.WriteLine($"Результат функции Аккермана для M={M} и N={N}: {result}");
