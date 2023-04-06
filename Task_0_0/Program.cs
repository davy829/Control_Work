// See https://aka.ms/new-console-template for more information


Console.WriteLine("Напишите пять слов после каждого жмите Ентер_ ");
 string[] massiv = new string[6];
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i]=Console.ReadLine()!;
}


for (int i = 0; i < massiv.Length; i++)
{
  Console.WriteLine($"{i}, {massiv[i]}");
}