/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

public class SamplesArray
{
    public static void Main(string[] args)
    {
    Console.Write("Введите целое число от 3 и более знаков: ");
    int num = int.Parse(Console.ReadLine());
    string q = num.ToString(); // У класса string нет метода, который изменял бы порядок элементов в строке на обратный :-(
    char[] qReverse = q.ToCharArray(); // Но такой метод есть у класса Array ! Преобразуем нашу строку q в символьный массив qReverse .
    Array.Reverse(qReverse); // Развернём символьный массив qReverse имеющимся методом
    q = new string(qReverse); // Преобразуем развёрнутый символьный массив qReverse обратно в строку
    int mun = int.Parse(q); // Преобразуем строку в число
    if (num == mun)
        Console.WriteLine($"Число {num} - палиндром.");
    else
        Console.WriteLine($"Число {num} - не палиндром.");
    }
}