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

Console.Clear();

int a = new Random().Next(1, 9);
int b = new Random().Next(1, 9);
int c = new Random().Next(1, 9);
int d = new Random().Next(1, 9);

char choice = Convert.ToChar("0");
int checkChoice = 0;
int threatCheck = 0;

if (a == c && b == d) Console.WriteLine("фигуры не могут стоять на одной клетке");
else
{
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
        if (choice == Convert.ToChar("c"))
        {
            CheckForKing(a, b, c, d);
            checkChoice = 1;
        }
        if (choice == Convert.ToChar("d"))
        {
            CheckForQueen(a, b, c, d);
            checkChoice = 1;
        }
        if (choice == Convert.ToChar("e"))
        {
            CheckForWhitePawn(a, b, c, d);
            checkChoice = 1;
        }
        if (choice == Convert.ToChar("f"))
        {
            CheckForBlackPawn(a, b, c, d);
            checkChoice = 1;
        }
        if (choice == Convert.ToChar("g"))
        {
            CheckForKnight(a, b, c, d);
            checkChoice = 1;
        }
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
    checkA = a;
    checkB = b;
    while (checkA < 9 && checkB > 0)
    {
        checkA++;
        checkB--;
        if (checkA == c && checkB == d) threatCheck = 1;
    }
    checkA = a;
    checkB = b;
    while (checkA > 0 && checkB > 0)
    {
        checkA--;
        checkB--;
        if (checkA == c && checkB == d) threatCheck = 1;
    }
    checkA = a;
    checkB = b;
    while (checkA > 0 && checkB < 9)
    {
        checkA--;
        checkB++;
        if (checkA == c && checkB == d) threatCheck = 1;
    }
    if (threatCheck == 1) Console.WriteLine($"Слон {a},{b} угрожает полю {c},{d}");
    else Console.WriteLine($"Слон {a},{b} не угрожает полю {c},{d}");
}
void CheckForKing(int a, int b, int c, int d)
{
    if (c == a && d == b + 1 || d == b - 1) Console.WriteLine($"Король {a},{b} одним ходом может попасть на поле {c},{d}");
    else if (c == a - 1 && d == b + 1 || d == b - 1) Console.WriteLine($"Король {a},{b} одним ходом может попасть на поле {c},{d}");
    else if (c == a + 1 && d == b + 1 || d == b - 1) Console.WriteLine($"Король {a},{b} одним ходом может попасть на поле {c},{d}");
    else Console.WriteLine($"Король {a},{b} одним ходом НЕ может попасть на поле {c},{d}");
}
void CheckForQueen(int a, int b, int c, int d)
{
    int checkA = a;
    int checkB = b;

    if (a == c || b == d) threatCheck = 1;
    else
    {
        while (checkA < 9 && checkB < 9)
        {
            checkA++;
            checkB++;
            if (checkA == c && checkB == d) threatCheck = 1;
        }
        checkA = a;
        checkB = b;
        while (checkA < 9 && checkB > 0)
        {
            checkA++;
            checkB--;
            if (checkA == c && checkB == d) threatCheck = 1;
        }
        checkA = a;
        checkB = b;
        while (checkA > 0 && checkB > 0)
        {
            checkA--;
            checkB--;
            if (checkA == c && checkB == d) threatCheck = 1;
        }
        checkA = a;
        checkB = b;
        while (checkA > 0 && checkB < 9)
        {
            checkA--;
            checkB++;
            if (checkA == c && checkB == d) threatCheck = 1;
        }
    }
    if (threatCheck == 1) Console.WriteLine($"Ферзь {a},{b} угрожает полю {c},{d}");
    else Console.WriteLine($"Ферзь {a},{b} не угрожает полю {c},{d}");
}
void CheckForWhitePawn(int a, int b, int c, int d)
{
    if (b == 2)
    {
        if (d == b + 2 && c == a || d == b + 1 && c == a) Console.WriteLine($"Белая пешка {a},{b} может пойти на поле {c},{d}");
        else if (d == b + 1 && c == a + 1 || d == b + 1 && c == a - 1) Console.WriteLine($"Белая пешка {a},{b} может пойти на поле {c},{d} побив фигуру");
        else Console.WriteLine($"Белая пешка {a},{b} НЕ может пойти на поле {c},{d}");
    }
    else if (d == b + 1 && c == a) Console.WriteLine($"Белая пешка {a},{b} может пойти на поле {c},{d}");
    else if (d == b + 1 && c == a + 1 || d == b + 1 && c == a - 1) Console.WriteLine($"Белая пешка {a},{b} может пойти на поле {c},{d} побив фигуру");
    else Console.WriteLine($"Белая пешка {a},{b} НЕ может пойти на поле {c},{d}");
}
void CheckForBlackPawn(int a, int b, int c, int d)
{
    if (b == 7)
    {
        if (d == b - 2 && c == a || d == b - 1 && c == a)
        {
            Console.WriteLine($"Чёрная пешка {a},{b} может пойти на поле {c},{d}");
        }
        else if (d == b - 1 && c == a + 1 || d == b - 1 && c == a - 1)
        {
            Console.WriteLine($"Чёрная пешка {a},{b} может пойти на поле {c},{d} побив фигуру");
        }
        else Console.WriteLine($"Чёрная пешка {a},{b} НЕ может пойти на поле {c},{d}");
    }
    else if (d == b - 1 && c == a) Console.WriteLine($"Чёрная пешка {a},{b} может пойти на поле {c},{d}");
    else if (d == b - 1 && c == a + 1 || d == b - 1 && c == a - 1)
    {
    Console.WriteLine($"Чёрная пешка {a},{b} может пойти на поле {c},{d} побив фигуру");
    }
    else Console.WriteLine($"Чёрная пешка {a},{b} НЕ может пойти на поле {c},{d}");
}
void CheckForKnight(int a, int b, int c, int d)
{
    int checkA = a - c;
    int checkB = b - d;
    if (checkA < 0) checkA = checkA * -1;
    if (checkB < 0) checkB = checkB * -1;

    if (checkA == 2 && checkB == 1 || checkA == 1 && checkB == 2)
    {
        Console.WriteLine($"Конь {a},{b} угрожает полю {c},{d}");
    }
    else Console.WriteLine($"Конь {a},{b} НЕ угрожает полю {c},{d}");
}

