/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumberShowSecondNumber (int numberfunction)
{
    numberfunction=numberfunction/10;
    numberfunction=numberfunction%10;
    return numberfunction;
}

Console.Write("Введите 3-х значное число: ");
int number=Convert.ToInt32(Console.ReadLine());
int result=GetNumberShowSecondNumber(number);
Console.WriteLine(result);
