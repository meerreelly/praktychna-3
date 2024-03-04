/*Обчислити значення виразу для усіх з діапазону кратних 
7-ми. На консоль вивести результат у вигляді, наприклад:*/
double y;
Console.WriteLine("x\ty");
for(int x = 14; x <= 100; x += 7)
{
    y=(Math.Pow(x+5,3))/(Math.Sqrt(x+1));
    Console.WriteLine($"{x}\t{y:F02}");
}