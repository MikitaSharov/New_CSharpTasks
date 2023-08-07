/* Известны год и номер месяца рождения человека, а также год и номер месяца сегодняшнего дня (январь — 1 и т. д.).
Определить возраст человека (число полных лет). В случае совпадения указанных номеров месяцев считать, что прошел полный год. */

DateTime currentDate = DateTime.Now;

// Получаем текущий год и месяц из даты
int currentYear = currentDate.Year;
int currentMonth = currentDate.Month;

int birthdayYear = new Random().Next(1900, currentYear);
int birthdayMonth = new Random().Next(1, 13);

if (currentMonth >= birthdayMonth) Console.WriteLine($"Ваш возраст: {currentYear - birthdayYear} лет и {currentMonth - birthdayMonth} месяц(ев)");
else Console.WriteLine($"Ваш возраст: {currentYear - birthdayYear--} лет и {12 + currentMonth - birthdayMonth} месяцев");