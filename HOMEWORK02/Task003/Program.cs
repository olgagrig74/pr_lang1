// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int num = 1;

if (num >= 1 && num <= 5)
{
    Console.WriteLine("Нет");
}
else if (num >= 6 && num <= 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Введенное значение не верное");
}