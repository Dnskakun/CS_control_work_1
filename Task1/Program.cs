// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении задачи не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

int numberElementsInArray = GetNumberFromUser();
string[] array = FillArray(numberElementsInArray);
string[] resultArray = SelectedArray(array);
PrintArray(array);
Console.Write(" -> ");
PrintArray(resultArray);


//Функции, используемые в массиве

int GetNumberFromUser()
{
    while (true)
    {
        Console.Write("Введите количество элементов в массиве строк: ");
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0)
            return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

string[] FillArray(int num)
{
    string[] arrayFill = new string[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите строку {i}-го элемента массива: ");
        arrayFill[i] = Console.ReadLine() ?? "";
    }
    return arrayFill;
}

string[] SelectedArray(string[] arr)
{
    int countNumberElements = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            countNumberElements++;
        }
    }
    if (countNumberElements > 0)
    {
        string[] newArr = new string[countNumberElements];
        countNumberElements = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                newArr[countNumberElements] = arr[i];
                countNumberElements++;
            }
        }
        return newArr;
    }
    else
    {
        string[] newArr = new string[countNumberElements];
        return newArr;
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    try
    {
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"\"{arr[i]}\", ");
    }
    Console.Write($"\"{arr[arr.Length - 1]}\"]");
    }
    catch
    {
        Console.Write("]");
    }
}


