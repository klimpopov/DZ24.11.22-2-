/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
string GetNumberDayAndShowWeekend(int NumberDay)
{
    string result;
    if ((NumberDay<1)|| (NumberDay>7))
    result="Число должно быть от 1-ого до 7-и";
    else if (NumberDay<6)
    result="Это не выходной день";
    else
    result = "Это выходной день";
    return result;
}

Console.WriteLine("Введите номер дня");
int number=Convert.ToInt32(Console.ReadLine());
string result = GetNumberDayAndShowWeekend(number);
Console.WriteLine(result);
