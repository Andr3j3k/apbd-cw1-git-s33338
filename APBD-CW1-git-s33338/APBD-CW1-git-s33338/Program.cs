// See https://aka.ms/new-console-template for more information

Console.WriteLine("Program do prostych obliczeń");
Console.Write("Podaj liczbę: ");
String input = Console.ReadLine();
 
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Podano poprawną liczbę: {number}");
}
else
{
    Console.WriteLine("Błąd: podana wartość nie jest liczbą całkowitą.");
}