// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] AddQuotationMarks(string[] arr)                                   // добавка кавычек к каждому элементу массива, для более красочного вывода результата
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = "“" + arr[i] + "”";
    }
    return arr;
}

string[] GetShortElementsArray (int sizeMas, string[] inpootMassive)      // формировка нового массива, чьи элементы не превышают 3 символов
{
    string[] shortElementsArray  = new string[sizeMas];
    int j = 0;
    for (int i = 0; i < inpootMassive.Length; i++)
    {
        if (inpootMassive[i].Length <= 3) 
        {
            shortElementsArray[j] = inpootMassive[i];
            j++;
        }
    }
    return shortElementsArray;
}

int GetCountLessThanThree (string[] mas)                                  // подсчет колличества элементов, чья длина не превышает 3 символов
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i].Length <= 3) count++;           
    }
    return count;
}

string[] InpootArray(int sizeArray)                                      // ввод элементов масссива с клавиатуры
{
    Console.WriteLine("Введите массив. ");
    string[] inpootArray = new string[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        Console.Write($"Введите {i+1} элемент: ");
        inpootArray[i] = Console.ReadLine();
    }
    return inpootArray;
}

int GetSize(string text)                                                 // ввод размера массива
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetSize("Введите колличество эллементов массива: ");
string[] array = InpootArray(size);
int shortSize = GetCountLessThanThree(array);
string[] shortArray = GetShortElementsArray(shortSize, array);
Console.Write($"[{string.Join(", ", AddQuotationMarks(array))}] → [{string.Join(", ", AddQuotationMarks(shortArray))}]");


