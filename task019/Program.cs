/* Даны цифры двух целых чисел: двузначного a2a1 и однозначного b, где a1 — число единиц, a2 — число десятков. 
Получить цифры числа, равного разности заданных чисел (известно, что это число двузначное).
Число-уменьшаемое и число-разность не определять. */

int digitA1 = 2;
int digitA2 = 5;
int digitB = 4;

if (digitA2 < digitB)
{
    digitA1--;
    digitA2 = 10 + digitA2 - digitB;
    Console.WriteLine($"{digitA1}{digitA2}");
}
else
{
    digitA2 = digitA2 - digitB;
    Console.WriteLine($"{digitA1}{digitA2}");
}