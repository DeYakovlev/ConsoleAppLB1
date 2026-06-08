//Задание 3 Зубчатый массив. Вариант 16. Подсчитать сумму элементов каждой строки и записать данные в новый массив. Найти максимальный элемент нового массива..

int max, min, size;
Random rand = new Random();
int[][] arr ;
int[] resArr;

while (true) {
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
    if (int.TryParse(Console.ReadLine(),out max) && max > min)
        break;
    Console.WriteLine("неверное значение");
}

arr = new int[size][];
resArr = new int[size];

for (int i = 0; i < size; i++)
{
    int summ = 0;
    Console.WriteLine();
    arr[i] = new int[rand.Next(1, size + 1)];
    for (int j = 0; j < arr[i].Length; j++)
    {
        arr[i][j] = rand.Next(min, max + 1);
        summ += arr[i][j];
        Console.Write($" {arr[i][j]} ");
    }
    resArr[i] = summ;
}

Console.WriteLine();

for (int i = 0; i < size;i++)
{
    Console.Write($" {resArr[i]} ");
}

int maxSum = resArr[0];

for (int i = 0;i < size;i++)
{
    if (resArr[i] > maxSum)
        maxSum = resArr[i];
}

Console.WriteLine();

Console.WriteLine($"Максимальная сумма строки: {maxSum}");    