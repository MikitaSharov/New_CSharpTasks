// Для натурального числа k напечатать фразу «мы нашли k грибов в лесу», согласовав окончание слова «гриб» с числом k.

Console.WriteLine("How much mushrooms?");
int qty = Convert.ToInt16(Console.ReadLine());

if (qty == 1) Console.WriteLine($"Мы нашли {qty} гриб в лесу");
else if (qty > 1 && qty < 5) Console.WriteLine($"Мы нашли {qty} гриба в лесу");
else if (qty > 4) Console.WriteLine($"Мы нашли {qty} грибов в лесу");
else Console.WriteLine($"Мы нашли не нашли грибов в лесу");