Console.Clear();
int[] perechislenie=new int[100];
int i=0;
int v=perechislenie.Length; // v - длина массива - источника чисел
while (i<v)
{
    perechislenie[i] = i; //заполнили массив числами от 1 до миллиона
    i++;
}
//Console.WriteLine(perechislenie[899999]);
// Заполняем второй массив на 100 000 элементов случайными числами
int[] arrayData=new int[10];
int v1=arrayData.Length; // Длина массива данных
i=0;
int temp=0;
while (i<v1)
{
    temp=new Random().Next(1,v);
    if (perechislenie[temp]>0)
    {
        arrayData[i]=temp;
        perechislenie[temp]=-1;
    }
    i++;
}
Console.WriteLine("__________________");
Console.WriteLine("__________________");
i=0;
while (i<10)
{
    Console.WriteLine($"{arrayData[i]}, {i}");
    i++;
}

//Сортируем пузырьком заполненный массив
i=0;
while (i<v1)
{
    int j=0;
    while (j<v1-1)
    {
        if (arrayData[j]>arrayData[j+1])
        {
            temp=arrayData[j];
            arrayData[j]=arrayData[j+1];
            arrayData[j+1]=temp;
        }
        j++;
    }
    i++;
}

Console.WriteLine("__________________");
i=0;
while (i<10)
{
    Console.WriteLine($"{arrayData[i]}, {i}");
    i++;
}