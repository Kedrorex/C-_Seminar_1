// Задача №16. Работа в группах
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число Б: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// int sqwere = numberA / numberB;
int sqwere1 = numberA / numberB;
int sqwere2 = numberB / numberA;

if (sqwere1 == numberB || sqwere2 == numberA)
{
  Console.Write("да");
} else 
{
  Console.Write("нет");
}