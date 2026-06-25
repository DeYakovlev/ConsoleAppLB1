//Задание 1 Одномерный массив целых чисел. Вариант 16. Подсчитать количество элементов, значения которых больше значения предыдущего элемента.

int min, max, size;
Random random = new Random();
int[] array;



while (true)
{
    Console.Write("Задайте размер массива от 0 до 99: ");
    //int.TryParse(Console.ReadLine(), out size);
    if (int.TryParse(Console.ReadLine(), out size) && size > 0 && size <= 99)
        break;
    Console.WriteLine("неверное значение");

}

while (true)
{
    Console.Write("Введите минимальное число диапазона Min: ");
    if (int.TryParse(Console.ReadLine(), out min))
        break;
    Console.WriteLine("невозможно разобрать в int");

}

while (true)
{
    Console.Write("Введите максимальное число диапазона Max: ");
    if (int.TryParse(Console.ReadLine(), out max) && max > min)
        break;
    Console.WriteLine("Неверное значение");

}

array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = random.Next(min, max + 1);
    if (i == 0)
        Console.Write($"| {array[i]} |");
    else
        Console.Write($" {array[i]} |");
}

int counter = 0;

for (int i = 1; i < size; i++)
{
    if (array[i] > array[i - 1])
        counter++;
}
Console.WriteLine();
Console.WriteLine($"количество элементов, значения которых больше значения предыдущего элемента: {counter}");