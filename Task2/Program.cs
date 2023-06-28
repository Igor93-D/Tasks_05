//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size, int leftRange, int rightRenge)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRenge + 1);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int Sum_numbers(int[] arrayN)
{
    int sum = 0;
    for (int i = 0; i < arrayN.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum=sum+arrayN[i];
        }
    }
    return sum;

}

int[] array = FillArray(6, 1, 5);
PrintArray(array);

int result = Sum_numbers(array);
System.Console.WriteLine(result);