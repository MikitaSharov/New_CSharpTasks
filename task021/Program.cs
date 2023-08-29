/* Даны цифры двух десятичных целых чисел: трехзначного a3a2a1 и двузначного b2b1, где a1 и b1 — число единиц,
a2 и b2 — число десятков, a3 — число сотен. Получить цифры, составляющие разность этих чисел (известно, что это число трехзначное). 
Число-уменьшаемое, число-вычитаемое и число-разность не определять. */

int digitA1 = new Random().Next(0, 10);
int digitA2 = new Random().Next(0, 10);
int digitA3 = 5;
int digitB1 = new Random().Next(0, 10);
int digitB2 = new Random().Next(0, 10);

Console.WriteLine($"{digitA3}{digitA2}{digitA1} - {digitB2}{digitB1}");

if (digitA1 < digitB1)
{
    digitA2--;
    digitA1 = 10 + digitA1 - digitB1;

    if (digitA2 < digitB2)
    {
        digitA3--;
        digitA2 = 10 + digitA2 - digitB2;
    }
    else digitA2 = digitA2 - digitB2;
}
else
{
    digitA1 = digitA1 - digitB1;
    if (digitA2 < digitB2)
    {
        digitA3--;
        digitA2 = 10 + digitA2 - digitB2;
    }
    else digitA2 = digitA2 - digitB2;

}
Console.WriteLine($"{digitA3}{digitA2}{digitA1}");