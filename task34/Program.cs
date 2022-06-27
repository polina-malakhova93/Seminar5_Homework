int size = Input("Задайте размер массива: ");
int[] array = new int[size];
FillArrayRandomNumbers(array);
PrintArray(array);
int count = 0;
for(int i =0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    count++;
}
Console.WriteLine("Количество четных чисел: " + count);


void FillArrayRandomNumbers(int[] array)
{
   for(int i =0; i < array.Length; i++)
   {
       array[i] = new Random().Next(100, 1000);
   }
}
void PrintArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

