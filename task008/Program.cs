/* Вася пытается высунуть голову в форточку размерами a и b см.
Приняв условно, что его голова — круглая диаметром d см,
определить, сможет ли Вася сделать это.
Для прохождения головы в форточку необходим зазор в 1 см с каждой стороны. */

int windowSideA = new Random().Next(0, 50);
int windowSideB = new Random().Next(0, 50);
int headD = new Random().Next(0, 50);
int headRWithZazor = headD / 2 + 1;

Console.WriteLine($"a = {windowSideA}, b = {windowSideB}, башка с зазором = {headD + 2}");

if (windowSideA <= windowSideB)
{
    if (headRWithZazor < windowSideA / 2) Console.WriteLine("Башка пролазит");
    else Console.WriteLine("Башка не пролазит");
}
else
{
    if (headRWithZazor < windowSideB / 2) Console.WriteLine("Башка пролазит");
    else Console.WriteLine("Башка не пролазит");
}