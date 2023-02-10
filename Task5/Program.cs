Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int x = number % 10;

Console.Write($"Остаток от трехзначного числа: {x}");
