/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
 в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

Console.WriteLine("Введите число M");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int num2 = Convert.ToInt32(Console.ReadLine());

// В СЛУЧАЕ, ЕСЛИ N<M, МЕНЯЕМ МЕСТАМИ ЗНАЧЕНИЯ
int num=0;
if (num1>num2)
{
    num=num1;
    num1=num2;
    num2=num;
}
// ОПРЕДЕЛЯЕМ ЧЕТНОСТЬ ПЕРВОГО ЧИСЛА, ЕСЛИ ПЕРВОЕ ЧИСЛО НЕЧЕТНОЕ, ДЕЛАЕМ ЕГО ЧЕТНЫМ
if (num1 % 2 !=0)
{
    num1=num1+1;
}

PrintNumbers (num1, num2);

void PrintNumbers(int start, int end)
{
     System.Console.Write(start + " ");
     if (start==end || start==end-1)
     {
        return;
     }
     else PrintNumbers(start+2,end);
}   