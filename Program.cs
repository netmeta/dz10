Console.Clear();

// Массивы из примера
string[] array1 = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

Console.WriteLine("Введите количество символов: "); // в условии 3 
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Исходный массив - [{string.Join(", ", array1)}]");
