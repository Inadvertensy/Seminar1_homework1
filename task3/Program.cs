// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Please enter number");
int number1=Convert.ToInt32(Console.ReadLine());
int divRem=number1%2;
//Console.WriteLine(divRem);
if (divRem==0)
{
    Console.Write("Number ");
    Console.Write(number1);
    Console.Write(" is even");

}
else 
{
    Console.Write("Number ");
    Console.Write(number1);
    Console.Write(" is not even");
}