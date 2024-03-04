/*Написати програму, що моделює роботу навігації.
 * Програма повинна пропонувати користувачу вибір дії шляхом введення символа з клавіатури. 
 * Доступними діями є:
 Hello - виводить на консоль текст «Hello, user!»
 Time - виводить години, хвилини та секунди на поточному ПК
 Exit - завершує роботу програми.*/
using System.Net.Security;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
while(true){
    Console.WriteLine("Hello - виводить на консоль текст «Hello, user!»\r\nTime - виводить години, хвилини та секунди на поточному ПК\r\nExit - завершує роботу програми.");
     string temp = Console.ReadLine();
    switch (temp){
        case "Hello":
            Console.WriteLine("Hello, user!");
            break;
        case "Time":
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString("HH:mm:ss"));
            break;
        case "Exit":
            return;
            break;
        default:
            break;}
}
