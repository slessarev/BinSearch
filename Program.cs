Console.Clear();
Console.WriteLine("Чтобы выйти - введите отрицательное число");
int[] perechislenie = new int[100000];
int i = 0;
int v = perechislenie.Length; // v - длина массива - источника чисел
while (i < v)
{
    perechislenie[i] = i; //заполнили массив числами от 1 до миллиона
    i++;
}
//Console.WriteLine(perechislenie[899999]);
// Заполняем второй массив на 100 000 элементов случайными числами
int[] arrayData = new int[10000];
int v1 = arrayData.Length; // Длина массива данных
i = 0;
int temp = 0;
while (i < v1)
{
    temp = new Random().Next(1, v);
    if (perechislenie[temp] > 0)
    {
        arrayData[i] = perechislenie[temp];
        perechislenie[temp] = -1;
        i++;
    }
}
//Console.WriteLine("__________________");
//Console.WriteLine("__________________");
//i = 0;
//while (i < 10)
//{
//   Console.WriteLine($"{arrayData[i]}, {i}");
//   i++;
//}

//Сортируем пузырьком заполненный массив
i = 0;
while (i < v1)
{
    int j = 0;
    while (j < v1 - 1)
    {
        if (arrayData[j] > arrayData[j + 1])
        {
            temp = arrayData[j];
            arrayData[j] = arrayData[j + 1];
            arrayData[j + 1] = temp;
        }
        j++;
    }
    i++;
}

//Создаю алгоритм бинарного поиска

int search = 0;
while (search >= -0)
{
    Console.WriteLine("__________________________________________________________");
    Console.Write("Введите ячейку массива чтобы посмотреть какое там число: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine($"В выбранной ячейке массива число {arrayData[num]}.");
    Console.WriteLine("__________________________________________________________");
    Console.Write("Введите искомое значение в массиве: ");
    search = int.Parse(Console.ReadLine());
    //int polovina = v1 / 2;
    //while (search != arrayData[polovina])
    //{
    //if (search > arrayData[polovina])
    //{
    //polovina = polovina + polovina / 2;
    //}
    //else
    //{
    //        polovina = polovina - polovina / 2;
    //}
    //}

    int low = 0;
    int high = v1 - 1;
    while (low <= high)
    {
        int mid = (low + high) / 2;
        int guess = arrayData[mid];
        if (guess == search)
        {
            Console.WriteLine($"Число {search} находится в ячейке номер {mid}");
        }
        if (guess > search) high = mid - 1;
        else low = mid + 1;
        //    Console.WriteLine($"Значение не существует");
    }
    //Console.WriteLine($"Число {search} находится в ячейке номер {polovina}");
}



//Console.WriteLine("__________________");
//i = 0;
//while (i < 10)
//{
//    Console.WriteLine($"{arrayData[i]}, {i}");
//    i++;
//}