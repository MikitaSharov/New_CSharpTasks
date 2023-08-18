/* В чемпионате по футболу команде за выигрыш дается 3 очка, за проигрыш — 0, за ничью — 1.
Известно количество очков, полученных командой за игру.
Определить словесный результат игры (выигрыш, проигрыш или ничья). */

Console.Write("Введите очки: ");
int points = Convert.ToInt16(Console.ReadLine());

if (points == 3) Console.Write("победа");
else if (points == 1) Console.Write("ничья");
else if (points == 0) Console.Write("проигрыш");
else Console.Write("неверный ввод");