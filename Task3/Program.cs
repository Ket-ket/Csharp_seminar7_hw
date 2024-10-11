// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// Например:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int ReadInt(string text){
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange){
    int [] tempArray = new int[size]; 
    Random rand = new Random(); 

    for( int i = 0; i < size; i++){
        tempArray[i] = rand.Next(leftRange, rightRange + 1); 
    }
    return tempArray;
}

void PrintArray(int[] array){
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void ChangeArray(int[] myArray, int i)
{
    if(i < 0) return;
    Console.Write(myArray[i] + " ");
    ChangeArray(myArray, i - 1);
}

int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 0, 100);
PrintArray(myArray);
ChangeArray(myArray, myArray.Length - 1);