Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = number * -1;

while (number >= index)
{
  Console.Write($"{index}, ");
  index++;
}