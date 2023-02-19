// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

metka:
System.Console.WriteLine("Введите 5 чисел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
if (array.Length != 5)
{
    System.Console.WriteLine("Количество чисел введено некорректно ");
    goto metka;
}

int sum = countAboveZero(array); 
Console.WriteLine($"{string.Join(", ", array)} = {sum}"); 

int countAboveZero(int[] array) 
{ 
 return array.Where(x => x > 0).Count(); 
}

