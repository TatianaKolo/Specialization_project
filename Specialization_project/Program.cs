/* Задача: "Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

string[] stringArray = new string[8] { "Rus", "UK", "Kazan", "Argentina", "Belarus", "China", "Guatemala", "USA"};
string[] minArray = new string[stringArray.Length];
int letter_counter = 0;
int size = 3;
for (int i = 0; i<stringArray.Length; i++)
{
    if (stringArray[i].Length <=size)
    {
        minArray[letter_counter]=stringArray[i];  
        letter_counter++;   
    }
}
Console.Write($"[{String.Join(" ", stringArray)}] ->");
Console.Write($"[{String.Join( " ", minArray)}]");

*/

void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите " + i + " элемент массива: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}
void NewArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
            Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите первоначальный размер элементов массива");
int minArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[minArray];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Введённый первоначальный массив: [{string.Join(", ", array)}]");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Полученный массив: ");
NewArray(array);