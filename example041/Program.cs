/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
вводим через один Enter (разбиваем через Split())*/

int[] InitArray(int dimension)
{
    Console.WriteLine("Введите пять любых чисел");
    int[] arr = new int[dimension];
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int GetPositiveNumber(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        count++;
    }
    return count;
}

int[] arr = InitArray(5);
int number = GetPositiveNumber(arr);

Console.WriteLine(string.Join(", ", arr));
Console.WriteLine($"Количество положительных чисел, введенных Вами = {number}");

