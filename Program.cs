Console.Clear();

// Массивы из примера
string[] array1 = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

Console.WriteLine("Введите количество символов: "); // в условии 3 
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Исходный массив - [{string.Join(", ", array1)}]");
Console.WriteLine($"Результат решения - [{string.Join(", ", GetArrayShortElement(array1, size))}]");


string[] GetArrayShortElement(string[] array, int n)
{
    int newSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n) newSize++;
    }
    string[] shortArray = new string[newSize];

    }
    return shortArray;
}
