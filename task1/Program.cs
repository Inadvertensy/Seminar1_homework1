// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Please enter the first number");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter thesecond number");
int number2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Maximum number is ");
if (number1>number2) 
{
Console.WriteLine(number1);

}
else 
{
Console.WriteLine(number2);

}