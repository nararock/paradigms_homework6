int binarySearch(int[] array, int searchNum, int indStart, int indEnd)
{
    if (array.Length == 0) return -1;

    if (indStart == indEnd)
    {
        return array[indStart] == searchNum ? indStart : -1;
    }
    else if (array[(indEnd + indStart) / 2] == searchNum)
    {
        return (indEnd + indStart) / 2;
    }
   

    if (array[(indEnd + indStart) / 2] < searchNum)
    {
        indStart = (indEnd + indStart) / 2 + 1;
    }
    else 
    {
        indEnd = (indEnd + indStart) / 2;
    }
    return binarySearch(array, searchNum, indStart, indEnd);
}

//проверка
int[] arr = { 1, 4, 6, 7, 9 };

int answer = binarySearch(arr, 1, 0, arr.Length - 1);
Console.WriteLine(answer);

int answer2 = binarySearch(arr, 4, 0, arr.Length - 1);
Console.WriteLine(answer2);

int answer3 = binarySearch(arr, 7, 0, arr.Length - 1);
Console.WriteLine(answer3);

int answer4 = binarySearch(arr, 9, 0, arr.Length - 1);
Console.WriteLine(answer4);

int answer5 = binarySearch(arr, 0, 0, arr.Length - 1);
Console.WriteLine(answer5);

int answer6 = binarySearch(arr, 5, 0, arr.Length - 1);
Console.WriteLine(answer6);

int answer7 = binarySearch(arr, 11, 0, arr.Length - 1);
Console.WriteLine(answer7);