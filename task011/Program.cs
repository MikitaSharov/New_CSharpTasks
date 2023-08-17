/* Даны три вещественных числа. Вывести на экран:
а) те из них, которые принадлежат интервалу (1,6—3,8);
б) те из них, которые принадлежат интервалу (0,7—5,1). */

Console.Write("Enter number 1: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number 2: ");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number 3: ");
double number3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Если хотите увидеть числа от 1,6 до 3,8 введите a, если от 0,7 до 5,1 введите b");
char choice = Convert.ToChar("0");
int check = 0;

while (check == 0)
{
    choice = Console.ReadKey(true).KeyChar;
    if (choice == Convert.ToChar("a"))
    {
        if (number1 > 1.6 && number1 < 3.8) Console.WriteLine(number1);
        if (number2 > 1.6 && number2 < 3.8) Console.WriteLine(number2);
        if (number3 > 1.6 && number3 < 3.8) Console.WriteLine(number3);
        check = 1;
    }
    else if (choice == Convert.ToChar("b"))
    {
        if (number1 > 0.7 && number1 < 5.1) Console.WriteLine(number1);
        if (number2 > 0.7 && number2 < 5.1) Console.WriteLine(number2);
        if (number3 > 0.7 && number3 < 5.1) Console.WriteLine(number3);
        check = 1;
    }
    else Console.WriteLine("неверный ввод");
}