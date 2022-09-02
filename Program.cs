/* int[] array = new int[123];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
    Console.WriteLine();
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10)
    {
        if (array[i] <= 99)
        {
            count++;
        }
    }
}
Console.WriteLine(count); */

Console.WriteLine("Напишите количество чисел в массиве");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = new int[N];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
    Console.WriteLine();
}
int [] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int [] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result [i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];
    return result;
}

Console.WriteLine(String.Join(" ", ResultArray(array)));