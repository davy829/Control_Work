//Задача: Написать программу, которая из имеющегося массива строк
//формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.WriteLine("Напишите пять слов после каждого жмите Ентер_ "); // 
string[] array = CreateArray(6);
int count = 0;
int index = 0;
string myword = string.Empty;


Console.WriteLine("_____________________________________________ ");
Console.WriteLine("your short words what have max 3 simbols: ");

int LenNewArray = СalculateShortWords(array);
string[] newArray = new string[LenNewArray];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[index] = array[i];
        index++;
    }
}

string[] CreateArray(int length)
{
    string[] massiv = new string[length];
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = Console.ReadLine()!;
    }
    return massiv;
}

int СalculateShortWords(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        myword = array[i];
        if (myword.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($"{array[i]}");
}



PrintArray(newArray);