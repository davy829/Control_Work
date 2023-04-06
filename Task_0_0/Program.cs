// See https://aka.ms/new-console-template for more information


Console.WriteLine("Напишите пять слов после каждого жмите Ентер_ ");
string[] massiv = new string[6];
int count = 0;
int index=0;
string myword=string.Empty;
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = Console.ReadLine()!;

}
Console.WriteLine("_____________________________________________ ");
Console.WriteLine("your short words what have max 3 simbols: ");
for (int i = 0; i < massiv.Length; i++)
{
    myword= massiv[i];
    if (myword.Length <= 3)
    {
        count++;
    }
}
string[] shortmassiv = new string[count];
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i].Length <= 3)
    {
    shortmassiv[index] = massiv[i];
    index++;
    }
}
for (int i = 0; i < count; i++)
{
  Console.WriteLine($"{shortmassiv[i]}");  
}
