Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число Б: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int sqwere = numberA / numberB;

if (sqwere == numberB)
{
  Console.Write($"Число {numberB} является корнем {numberA}");
}
else 
{
  Console.Write($"Число {numberB} не является корнем {numberA}");
}