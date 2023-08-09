/* Пассажир должен был сдать в камеру хранения пустой чемодан в форме параллелепипеда размерами a1 , a2 и a3 см и
коробку размерами b1 , b2 и b3 см. Оплачивать нужно каждый размещаемый предмет.
Определить, сможет ли пассажир сэкономить на оплате, 
поместив коробку в чемодан так, что стороны чемодана и коробки будут параллельны либо перпендикулярны друг другу. */

int bagSideA1 = new Random().Next(0, 100);
int bagSideA2 = new Random().Next(0, 100);
int bagSideA3 = new Random().Next(0, 100);
int boxSideB1 = new Random().Next(0, 100);
int boxSideB2 = new Random().Next(0, 100);
int boxSideB3 = new Random().Next(0, 100);

if ((bagSideA1 >= boxSideB1 && bagSideA2 >= boxSideB2 && bagSideA3 >= boxSideB3) ||
    (bagSideA1 >= boxSideB1 && bagSideA2 >= boxSideB3 && bagSideA3 >= boxSideB2) ||
    (bagSideA1 >= boxSideB2 && bagSideA2 >= boxSideB1 && bagSideA3 >= boxSideB3) ||
    (bagSideA1 >= boxSideB2 && bagSideA2 >= boxSideB3 && bagSideA3 >= boxSideB1) ||
    (bagSideA1 >= boxSideB3 && bagSideA2 >= boxSideB1 && bagSideA3 >= boxSideB2) ||
    (bagSideA1 >= boxSideB3 && bagSideA2 >= boxSideB2 && bagSideA3 >= boxSideB1)) Console.WriteLine($"box in bag");
else Console.WriteLine($"box out bag");