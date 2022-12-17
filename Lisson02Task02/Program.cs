// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 1. Сгенерировать трехзначное число
// 2. Разбить его на цифры
// 3. Составить новое число
// 4. Показать его на экран

Console.WriteLine("Start");

int value = new Random().Next(100, 1000);  // [100;999]

int a = value / 100;
int b = (value / 10) % 10;
int c = value % 10;

int result = a * 10 + c;

Console.WriteLine(value);
Console.WriteLine(result);
Console.WriteLine("end");