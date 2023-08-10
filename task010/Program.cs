/* Дано натуральное число n (n <= 9999). Выяснить, верно ли, что это число содержит ровно три одинаковые цифры с учетом четырех цифр,
как, например, числа 3363, 4844, 0300 и т. п. */

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[4];
// for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 9);
int findDigit = 0;
int count = 0;

for (int i = array.Length - 1; i >= 0; i--)
{
    array[i] = number % 10;
    number /= 10;
}

for (int j = 0; j < array.Length; j++)
{
    findDigit = array[j];
    foreach (int item in array)
    {
        if (item == findDigit) count++;
    }
}

if (count == 10) Console.WriteLine("true");
else Console.WriteLine("false");
/* Console.WriteLine(string.Join(", ", array));
Console.WriteLine(count); */
