Console.Write("Digite um número: ");
if (!int.TryParse(Console.ReadLine(), out int numero))
   {
    Console.WriteLine("Entrada inválida.");
    return;
   }

Console.WriteLine($"Tabuada do número: {numero}");
Console.WriteLine();

for (int i = 0; i <= 10; i++)
  {
    Console.WriteLine($"{numero} x {i} = {numero * i}");
  }
