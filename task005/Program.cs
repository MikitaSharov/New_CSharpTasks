/* Дано трехзначное число. Определить:
а) является ли сумма его цифр двузначным числом;
б) является ли произведение его цифр трехзначным числом;
в) больше ли числа а произведение его цифр;
г) кратна ли пяти сумма его цифр;
д) кратна ли сумма его цифр числу а. */

int n = new Random().Next(100, 1000);
int n1 = n % 10;
int n10 = n / 10 % 10;
int n100 = n / 100;
int sumDigits = n1 + n10 + n100;
int productDigits = n1 * n10 * n100;
int a = new Random().Next(0, 100);

Console.WriteLine($"n = {n}, a = {a}");
if (sumDigits >= 10 && sumDigits < 100) Console.WriteLine($"сумма цифр числа {n} = {sumDigits}, что является двузначным числом");
else Console.WriteLine($"сумма цифр числа {n} = {sumDigits}, что не является двузначным числом");
if (productDigits >= 100 && productDigits < 1000) Console.WriteLine($"произведение цифр числа {n} = {productDigits}, что является трёхзначным числом");
else Console.WriteLine($"произведение цифр числа {n} = {productDigits}, что не является трёхзначным числом");
if (productDigits > a) Console.WriteLine($"произведение цифр числа {n} = {productDigits}, что больше числа {a}");
else Console.WriteLine($"произведение цифр числа {n} = {productDigits}, что меньше числа {a}");
if (sumDigits % 5 == 0) Console.WriteLine($"сумма цифр числа {n} = {sumDigits}, что кратно 5");
else Console.WriteLine($"сумма цифр числа {n} = {sumDigits}, что не кратно 5");
if (sumDigits % a == 0) Console.WriteLine($"сумма цифр числа {n} = {sumDigits}, что кратно числу {a}");
else Console.WriteLine($"сумма цифр числа {n} = {sumDigits}, что не кратно числу {a}");