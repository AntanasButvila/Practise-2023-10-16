// Задача 8: Напишите программу, 
// которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.

// int start = 1;
// int number = 11; // N

// if (number < 0)
// {
//     number *= -1; // N = N * -1
// }
// while (start < number) // От start до N включительно
// {
//     start += 1; // start = start + 1
//     if ((start % 2) == 0) // проверка на четность
//     {
//                 Console.Write($"{start}\t");// Интерполяция: $"Текст {переменная} текст"
//     }
// }


// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Рандомное число: {number}");
// // Math.Round(число, количество знаков)
// Console.WriteLine(Math.Round(1.275, 1));
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// int max = firstDigit;
// if(secondDigit > max)
// {
//     max = secondDigit;
// }
// Console.WriteLine($"Макс.цифра в числе {number} -> {max}");

// Напишите программу, 
// которая выводит случайное
// трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// // 918 -> 98

// int number = new Random().Next(100, 1000); // 100-999
// // firstDigit - кол-во десятков (4 десятка => 40)
// // thirdDigit - кол-во единиц (6 единиц => 6*1)
// int firstDigit = number / 100; // 456 / 100 = 4
// int thirdDigit = number % 10; // 456 % 10 = 6
// int result = firstDigit * 10 + thirdDigit; // 4*10 +6
// Console.WriteLine($"{number} -> {result}");

// // Альтернативное решение этой задачи 
// Console.Write("Введите число: ");
// string stringNumber = Console.ReadLine();
// // Строчка - массив символов
// int number; // Ничего не клал в нее
// // TryParse(строчка, out переменная для результата)
// bool isNumber = int.TryParse(stringNumber, out number);
// // Если isNumber == True, значит строчка stringNumber 
// // состоит ТОЛЬКО из цифр; False - в строке есть буквы.
// // Если в stringNumber только цифры, то 
// // в переменную number попадет само число; иначе - 0
// Console.WriteLine($"Длина строки(кол-во символов): {stringNumber.Length}");
// if (isNumber && stringNumber.Length >= 3) // isNumber == True
// {
//     Console.WriteLine("Ваша строчка состоит ТОЛЬКО из цифр");
//     Console.WriteLine($"{stringNumber} => {stringNumber[0]}{stringNumber[2]}");
// }
// else
// {
//     Console.WriteLine("В строчке присутсвуют буквы ИЛИ длина строки < 3 символов");
// }

// Напишите программу, которая 
// принимает на вход число 
// и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161-> да (7 * 23 = 161, НОД)
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine("Число делится и на 7, и на 23 одновременно");
}
else
{
    Console.WriteLine("Не делится на 7 или на 23 :(");
}