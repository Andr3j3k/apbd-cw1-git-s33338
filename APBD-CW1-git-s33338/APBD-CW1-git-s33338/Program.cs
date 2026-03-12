// See https://aka.ms/new-console-template for more information

using APBD_CW1_git_s33338;

Console.WriteLine("=== Program do prostych obliczeń ===");
Console.Write("Podaj liczbę całkowitą: ");
String input = Console.ReadLine();
 
if (int.TryParse(input, out int number))
{
    Console.WriteLine();
    Console.WriteLine("Wyniki obliczeń:");
    Console.WriteLine($"Liczba: {number}");
    Console.WriteLine($"Kwadrat: {StatisticsHelper.Square(number)}");
    Console.WriteLine($"Sześcian: {StatisticsHelper.Cube(number)}");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Błąd: musisz podać poprawną liczbę całkowitą.");
}