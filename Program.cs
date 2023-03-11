// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большое, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2; b = 10 -> max = 10
//a = -9; b = -3 -> max = -3

//Console.WriteLine("Input first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input second number");
//int num2 = Convert.ToInt32(Console.ReadLine());
//int max = num1;
//int min = num1;

//if (num1 > num2)
//Console.WriteLine($"Fisrt number {num1} is max, second number {num2} is min");
//if (num2 > num1)
//Console.WriteLine($"Second number {num2} is max, first number {num1} is min");

// Задача 4. Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.

//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22

//Console.WriteLine("Input first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input second number");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input third number");
//int num3 = Convert.ToInt32(Console.ReadLine());
//int max = num1;

//if (num1 > num2 && num3)
//Console.WriteLine($"Fisrt number {num1} is max");
//if (num2 > num1 && num3)
//Console.WriteLine($"Second number {num2} is max");
//if (num3 > num1 && num2)
//Console.WriteLine($"Third number {num2} is max");

// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число чётным (делится ли оно на два без остатка).

//Console.WriteLine("Input number");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 2 == 0)
//{
  //  int reminder = num %  2;
    //Console.WriteLine($"Your number {num} -> {reminder} is even");
//}
//else
//{
 //Console.WriteLine($"Your number {num} is odd");   
//}

//Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());
for (int a = 1; a <= n; a ++)
{
    if (a % 2 == 0)
    Console.WriteLine(a + " ");
}




