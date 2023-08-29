/* Поле шахматной доски определяется парой натуральных чисел, каждое из которых не превосходит 8:
первое число — номер вертикали (при счете слева направо), второе — номер горизонтали (при счете снизу вверх).
Даны натуральные числа a, b, c, d, каждое из которых не превосходит 8.
а) на поле (a, b) расположена ладья. Определить, угрожает ли она полю (c, d);
б) на поле (a, b) расположен слон. Определить, угрожает ли он полю (c, d);
в) на поле (a, b) расположен король. Определить, может ли он одним ходом попасть на поле (c, d);
г) на поле (a, b) расположен ферзь. Определить, угрожает ли он полю (c, d);
д) на поле (a, b) расположена белая пешка. Определить, может ли она одним ходом попасть на поле (c, d):
— при обычном ходе;
— когда она «бьет» фигуру или пешку соперника;
Примечание. Белые пешки перемещаются на доске снизу вверх.
е) на поле (a, b) расположена черная пешка. Определить, может ли она одним ходом попасть на поле (c, d):
— при обычном ходе;
— когда она «бьет» фигуру или пешку соперника;
Примечание. Черные пешки перемещаются на доске сверху вниз.
ж) на поле (a, b) расположен конь. Определить, угрожает ли он полю (c, d).
Во всех задачах ответ проверить на шахматной доске или на клетчатой бумаге. */

int a = new Random().Next(1, 9);
int b = new Random().Next(1, 9);
int c = new Random().Next(1, 9);
int d = new Random().Next(1, 9);

char choice = Convert.ToChar("0");
int checkChoice = 0;
int threatCheck = 0;

if (a == c && b == d) Console.WriteLine("фигуры не могут стоять на одной клетке");

while (checkChoice == 0)
{
    Console.WriteLine("enter a, b, c, d, e, f or g");
    choice = Console.ReadKey(true).KeyChar;
    if (choice == Convert.ToChar("a"))
    {
        CheckForRook(a, b, c, d);
        checkChoice = 1;
    }
    if (choice == Convert.ToChar("b"))
    {
        CheckForBishop(a, b, c, d);
        checkChoice = 1;
    }
}

void CheckForRook(int a, int b, int c, int d)
{
    if (a == c || b == d) Console.WriteLine($"Ладья {a},{b} угрожает полю {c},{d}");
    else Console.WriteLine($"Ладья {a},{b} не угрожает полю {c},{d}");
}
void CheckForBishop(int a, int b, int c, int d)
{
    int checkA = a;
    int checkB = b;


    while (checkA < 9 && checkB < 9)
    {
        checkA++;
        checkB++;
        if (checkA == c && checkB == d) threatCheck = 1;
    }
    while (checkA < 9 && checkB > 0)
    {
        checkA++;
        checkB--;
        if (checkA == c && checkB == d) threatCheck = 1;
    }
    while (checkA > 0 && checkB > 0)
    {
        checkA--;
        checkB--;
        if (checkA == c && checkB == d) threatCheck = 1;
    }
    while (checkA > 0 && checkB < 9)
    {
        checkA--;
        checkB++;
        if (checkA == c && checkB == d) threatCheck = 1;
    }
    if (threatCheck == 1) Console.WriteLine($"Слон {a},{b} угрожает полю {c},{d}");
    else Console.WriteLine($"Слон {a},{b} не угрожает полю {c},{d}");
    checkChoice = 1;
}
