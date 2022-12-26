// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array1 = new string[4] {"hello", "2" ,"world", ":-)"};

string[] FilterLongerThan3(string[] array1)
{
    int count = 0;
    int size = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        size++;
        }
    }
    string[] array2 = new string[size];
    for (int j = 0; j < array1.Length; j++)
    {
        if(array1[j].Length <= 3)
        {
            array2[count] = array1[j];
            count++;
        }
    }
    return array2;    
    
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(FilterLongerThan3(array1));
