//Задание 2 Квадратный массив. Вариант 16.Определить, есть ли в данном массиве строка, состоящая только из положительных элементов. 

int max, min, size;
int[][] arr;

Random random = new Random();

while (true)
{
    Console.Write("Введите размерность массива от 0 до 99: ");
    if (int.TryParse(Console.ReadLine(), out size) && size > 0 && size < 99)
        break;
    //Console.Write($"{size}");
    Console.WriteLine($"Введенное значение size:{size} не попадает в допустимый диапазон");
}

while (true)
{
    Console.Write("Введите минимальное занчение: ");
    if (int.TryParse(Console.ReadLine(), out min)) 
    break;
    Console.WriteLine("неверное значение");
}

while (true)
{
    Console.Write("Введите максимальное занчение: ");
    if (int.TryParse(Console.ReadLine(), out max) && max > min)
        break;
    Console.WriteLine("неверное значение");
}

arr = new int[size][];

for (int i = 0; i < size; i++)
{
    arr[i] = new int[size];
    if (i > 0)
        Console.WriteLine();

    for (int j = 0; j < size; j++)
    {
        arr[i][j] = random.Next(min, max);
        Console.Write($" {arr[i][j]} ");
    }
}

bool Strispositive = false;

for  (int i = 0; i < size; i++)
{
    if (Strispositive == false)
    {
        for (int j = 0; j < size; j++)
        {
            if (arr[i][j] > 0)
                Strispositive = true;
            else
            {
                Strispositive = false;
                break;
            }


        }
    }
    else
    {
        break;
    }
}
Console.WriteLine();

if (Strispositive == true)
    Console.WriteLine("Есть строка только из положительных");
else
    Console.WriteLine("Нет строк только из положительных");
