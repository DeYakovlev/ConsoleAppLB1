//Задание 4 Методы. Вариант 16. Метод принимает массив и удаляет все отрицательные элементы (массив станет короче).

int size, max, min;
Random rand = new Random();
int[] arr;

while (true)
{
    Console.Write("Введите размер массива от 0 до 99: ");
    if (int.TryParse(Console.ReadLine(), out size) && size > 0 && size < 100)
        break;
    Console.WriteLine("неверное значение");
}

while (true)
{
    Console.Write("Введите минимальное значение: ");
    if (int.TryParse(Console.ReadLine(), out min))
        break;
    Console.WriteLine("неверное значение");
}

while (true)
{
    Console.Write("Введите максимальное значение: ");
    if (int.TryParse(Console.ReadLine(), out max) && max > min)
        break;
    Console.WriteLine("неверное значение");
}

arr = new int[size];
for (int i = 0; i < size; i++)
{
    arr[i] = rand.Next(min,max + 1);
    Console.Write($" {arr[i]} ");
}

Console.WriteLine();
method16(ref arr);

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($" {arr[i]} ");
}




void method16(ref int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] < 0)
        {
            Array.Copy(arr, i + 1, arr, i, count - i - 1);
            count--;
            i--;
        }
    }
    Array.Resize(ref arr, count);
}