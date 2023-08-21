/* Даны цифры двух двузначных чисел, записываемых в виде a2a1 и b2b1 , где a1 и b1 — число единиц, a2 и b2 — число десятков.
Получить цифры числа, равного разности заданных чисел (известно, что это число двузначное). 
Число-уменьшаемое, число-вычитаемое и число-разность не определять. */

int digitA1 = 5;
int digitA2 = 7;
int digitB1 = 8;
int digitB2 = 8;
int digitC1 = 0;
int digitC2 = 0;

if (digitB2 > digitA2)
{
    digitC1 = digitA1 - 1 - digitB1;
    digitC2 = 10 + digitA2 - digitB2;
    if (digitC1 < 0) digitC1 = digitC1 * -1;
    Console.WriteLine($"{digitC1}{digitC2}");
}
else
{
    digitC1 = digitA1 - digitB1;
    digitC2 = digitA2 - digitB2;
    if (digitC1 < 0) digitC1 = digitC1 * -1;
    Console.WriteLine($"{digitC1}{digitC2}");
}

