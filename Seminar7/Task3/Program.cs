double[] arr = {1.2, 3.4, 5.6, 7.8, 9.0};
double min = arr[0];
double max = arr[0];
for(int i = 1; i < arr.Length; i++)
{
    if(arr[i] < min)
    {
        min = arr[i];
    }
    else if(arr[i] > max)
    {
        max = arr[i];
    }
}
double diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");
