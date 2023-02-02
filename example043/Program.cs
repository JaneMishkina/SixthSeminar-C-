/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Повторите ввод");
        }
    }

    return result;
}

double b1 = GetNumber("Введите любое целое число для переменной b1");
double k1 = GetNumber("Введите любое целое число для переменной k1");
double b2 = GetNumber("Введите любое целое число для переменной b2");
double k2 = GetNumber("Введите любое целое число для переменной k2");

double x = (b2-b1)/(k1-k2);
double y = k1*x + b1;

Console.WriteLine($"Tочка пересечения двух прямых имеет координаты: ({Math.Round(x, 1)} ; {Math.Round(y, 1)})");

