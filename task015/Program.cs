﻿/* Мастям игральных карт условно присвоены следующие порядковые номера: масти «пики» — 1, масти «трефы» — 2,
масти «бубны» — 3, масти «червы» — 4,
а достоинству карт: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14 
(порядковые номера карт остальных достоинств соответствуют их названиям: «шестерка», «девятка» и т. п.). 
По заданным номеру масти m (1 <= m <= 4) и номеру достоинства карты k (6 <= k <= 14) определить полное название 
(масть и достоинство) соответствующей карты в виде «Дама пик», Шестерка бубен» и т. п. */

int suit = new Random().Next(1, 5);
int dignity = new Random().Next(6, 15);
if (dignity < 11) Console.Write(dignity + " ");
if (dignity == 11) Console.Write("валет ");
if (dignity == 12) Console.Write("дама ");
if (dignity == 13) Console.Write("король ");
if (dignity == 14) Console.Write("туз ");
if (suit == 1) Console.Write("пике");
if (suit == 2) Console.Write("треф");
if (suit == 3) Console.Write("бубна");
if (suit == 4) Console.Write("черва");