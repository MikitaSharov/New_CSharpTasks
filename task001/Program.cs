/* написать метод заполнения массива рандомными цифрами от 10 до 99
(этот метод нам дальше будет нужен везде, так что делаем красивый. чтобы цифры через ",", */

int[] array = new int[10];

void RandomArray(int[] collection)
{
    int length = collection.Length;

    for (int index = 0; index < length; index++) collection[index] = new Random().Next(10, 100);
    foreach (int item in array) Console.Write($"{item}, ");
}

RandomArray(array);