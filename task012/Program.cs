// Даны четыре целых числа. Определить, сколько из них четных.

int countEven = 0;
countEven = CountEven(6, 2, 3, 4);
int CountEven(int number1, int number2, int number3, int number4)
{
    if (number1 % 2 == 0) countEven++;
    if (number2 % 2 == 0) countEven++;
    if (number3 % 2 == 0) countEven++;
    if (number4 % 2 == 0) countEven++;

    return countEven;
}

Console.Write(countEven);