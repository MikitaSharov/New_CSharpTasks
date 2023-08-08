// Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?

int roundR = new Random().Next(1, 100);
int squareSide = new Random().Next(1, 100);

double roundS = Math.PI * roundR * roundR;
int squareS = squareSide * squareSide;

if (roundS>squareS) Console.WriteLine($"S round bigger S square");
else Console.WriteLine($"S square bigger S round");