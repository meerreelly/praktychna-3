using System.Net.Security;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
/*Задача 5.1.
Написати програму, що знаходить добуток чисел у вказаному користувачем діапазоні.*/
Console.WriteLine("Введіть початок діапазону");
int begin = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть кінець діапазону");
int end = int.Parse(Console.ReadLine());
double sum=1;
for(int i = begin; i <= end;i++)
{
   sum*=i;
}
Console.WriteLine($"Добуток чисел в діапазоні:{sum}");