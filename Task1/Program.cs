//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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


int Even_numbers(int[] arrayEv)
{
    int count = 0;
    for (int i = 0; i < arrayEv.Length; i++)
    {
        if (arrayEv[i] % 2 == 0)
        {
            count++;
        }

    }
    return count;
}

int[] array = FillArray(10, 99, 999);
PrintArray(array);
int result= Even_numbers(array);
System.Console.WriteLine(result);