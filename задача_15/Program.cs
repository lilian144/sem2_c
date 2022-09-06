// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 7 || number < 1)
{
    Console.WriteLine("Введите число от 1 до 7");
}
else if(number == 7 || number == 6)
{
    Console.WriteLine("да");

}
else
{
    Console.WriteLine("нет");
}