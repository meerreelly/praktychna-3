/*Дано цілі додатні числа i та k. Реалізувати функцію, що обчислює значення виразу:*/
using System.Net.Security;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Введіть число і");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть число k");
int k = int.Parse(Console.ReadLine());
int z;
if (i % k == 0)
{
   z =i-k;
}else if(k % i == 0)
{
    z= k-i;
}else z=k+i;
Console.WriteLine($"z={z}");
