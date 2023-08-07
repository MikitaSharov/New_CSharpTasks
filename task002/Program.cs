// Известны два расстояния: одно в километрах, другое — в футах (1 фут 0,305 м). Какое из расстояний меньше?

int km = new Random().Next(0,100);
int ft = new Random().Next(0,100000);
double ftToKm = ft * 0.000305;


if (km < ftToKm) Console.WriteLine($"{km} км. меньше чем {ft} футов");
else Console.WriteLine($"{ft} футов. меньше чем {km} км");