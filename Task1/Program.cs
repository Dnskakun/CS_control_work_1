// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении задачи не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

int numberElementsInArray = GetNumberFromUser();    //ввод кол-ва элементов будущего массива через функцию GetNumberFromUSer
string[] array = FillArray(numberElementsInArray);  //создаем и сразу заполняем новый массив через функцию FillArray
string[] resultArray = SelectedArray(array);        //получаем новый массив из строк, длина которых меньше или равна 3
PrintArray(array);                                  //выводим начальный массив в консоль
Console.Write(" -> ");
PrintArray(resultArray);                            //выводим полученный массив в консоль


//Функции, используемые в массиве

int GetNumberFromUser()                             //функция, получающая от пользователя целое число больше нуля
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

string[] FillArray(int num)                         //функция заполнения массива строками
{
    string[] arrayFill = new string[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите строку {i}-го элемента массива: ");
        arrayFill[i] = Console.ReadLine() ?? "";
    }
    return arrayFill;
}

string[] SelectedArray(string[] arr)                //функция, создающая новый массив из тех строк изначального массива,
{                                                   //длина которых меньше или равна 3
    int countNumberElements = 0;
    for (int i = 0; i < arr.Length; i++)            //цикл, для определения количества элементов массива, длина строк
    {                                               //которых меньше или равна 3
        if (arr[i].Length <= 3)
        {
            countNumberElements++;
        }
    }
    if (countNumberElements > 0)                    //условие, если в изначальном массиве есть хотя бы один элемент,
    {                                               //длина строки которого меньше или равна 3
        string[] newArr = new string[countNumberElements];
        countNumberElements = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)                             //условие, если длина строки элемента изначального массива
            {                                                   //меньше или равна 3, то записываем этот элемент в новый
                newArr[countNumberElements] = arr[i];           //массив
                countNumberElements++;
            }
        }
        return newArr;
    }
    else
    {
        string[] newArr = new string[countNumberElements];      //если в изначальном массиве нет ни одного элемента, длина
        return newArr;                                          //строки которого меньше или равна 3, то возвращаем
    }                                                           //пустой массив
}

void PrintArray(string[] arr)                                   //функция для вывода элементов массива в консоль
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


