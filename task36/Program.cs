int size = Input("Задайте размер массива: ");
int[] array = new int[size];
FillArrayRandomNumbers(array);
PrintArray(array);
int sum = 0;
for(int i =1; i < array.Length; i+=2)
{
    sum+=array[i];
}
Console.WriteLine("Сумма элементов,стоящих на нечетных позициях: " + sum);


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


