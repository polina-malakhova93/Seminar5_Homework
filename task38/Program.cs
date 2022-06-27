int size = Input("Задайте размер массива: ");
int[] array = new int[size];
FillArrayRandomNumbers(array);
PrintArray(array);
int max = array[0];
int min = array[0];
for(int i =1; i < array.Length; i++)
{
    if(array[i] < min)
       min = array[i];
    if(array[i] > max)
       max = array[i];
}
int diff = max - min;
Console.WriteLine(max); // это я себя проверяю,что всё правильно работает :)
Console.WriteLine(min);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + diff);


void FillArrayRandomNumbers(int[] array)
{
   for(int i =0; i < array.Length; i++)
   {
       array[i] = new Random().Next(1, 100);
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


