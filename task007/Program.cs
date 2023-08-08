// Проверить, принадлежит ли число, введенное с клавиатуры, интервалу (–5, 3).

Console.Write("Enter numder: ");
double number = Convert.ToDouble(Console.ReadLine());

if (number<3 && number>-5) Console.Write("true");
else Console.Write("false");