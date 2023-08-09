/* Вася пытается высунуть голову в форточку размерами a и b см.
Приняв условно, что его голова — круглая диаметром d см,
определить, сможет ли Вася сделать это.
Для прохождения головы в форточку необходим зазор в 1 см с каждой стороны. */

int windowSideA = new Random().Next(0, 50);
int windowSideB = new Random().Next(0, 50);
int headD = new Random().Next(0, 50);
int minSize = headD + 2;

Console.WriteLine($"a = {windowSideA}, b = {windowSideB}, башка с зазором = {minSize}");

if (windowSideA >= minSize && windowSideB >= minSize) Console.WriteLine("Башка пролазит");
else Console.WriteLine("Башка не пролазит");