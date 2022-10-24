/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введи число");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
if (str.Length < 3)
{
Console.WriteLine("Третьей цифры нет");
}
Console.WriteLine($"{str[2]}");
