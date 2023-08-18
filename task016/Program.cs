/* Дата некоторого дня характеризуется двумя натуральными числами: m (порядковый номер месяца) и n (число).
По заданным n и m определить:
а) дату предыдущего дня (принять, что n и m не характеризуют 1 января);
б) дату следующего дня (принять, что n и m не характеризуют 31 декабря). */

string[] arrayMonth = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
Console.Write("Day: ");
int day = Convert.ToInt16(Console.ReadLine());
Console.Write("Month: ");
int month = Convert.ToInt16(Console.ReadLine());
PrintDay(day, month);

void PrintDay(int day, int month)
{
    for (int i = 0; i < arrayMonth.Length; i++)
    {
        if (month - 1 == i) Console.WriteLine($"{day} {arrayMonth[i]}");
    }
}
char choice = Convert.ToChar("0");
int checkChoice = 0;

while (checkChoice == 0)
{
    Console.WriteLine("for yesterday enter a, for tomorrow enter b");
    choice = Console.ReadKey(true).KeyChar;
    if (choice == Convert.ToChar("a"))
    {
        if (day == 1)
        {
            if (month == 5 || month == 7 || month == 10 || month == 12)
            {
                day = 30;
                month--;
            }
            else if (month == 3)
            {
                day = 28;
                month--;
            }
            else
            {
                day = 31;
                month--;
            }
        }
        else day--;

        PrintDay(day, month);
        checkChoice = 1;
    }
    if (choice == Convert.ToChar("b"))
    {
        if (day == 28 && month == 2)
        {
            day = 1;
            month++;

        }
        else if (day == 30)
        {
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                day = 1;
                month++;
            }
        }
        else if (day == 31)
        {
            day = 1;
            month++;
        }
        else day = day++;
        PrintDay(day, month);
        checkChoice = 1;
    }
}