// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введи число: ");
string number = Console.ReadLine();
if (number.Length==5)
    {           
         if (number[0]==number[4] && number[1]==number[3])
            {
            Console.WriteLine("Является палиндромом");
            }
            else 
            {
            Console.WriteLine("Не является палиндромом");
            }
    }
else Console.WriteLine ("Неверное число");
