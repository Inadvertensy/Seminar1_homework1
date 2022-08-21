// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.WriteLine("Please enter number");
int number1=Convert.ToInt32(Console.ReadLine());
int divRem=number1%2;
if(number1>0) {

Console.WriteLine("All even numbers are:");
if(divRem==0)
{
   
   while(number1>1){
    Console.WriteLine(number1+",");
    number1=number1-2;
} 
}
else
number1=number1-1;
while(number1>1){
    Console.WriteLine(number1+",");
    number1=number1-2;
}
}
else 
{
Console.WriteLine("All even numbers are:");
if(divRem==0)
{
   
   while(number1<1){
    Console.WriteLine(number1+",");
    number1=number1+2;
} 
}
else
number1=number1+1;
while(number1<1){
    Console.WriteLine(number1+",");
    number1=number1+2;
}

}


