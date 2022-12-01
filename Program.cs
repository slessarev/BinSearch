Console.Clear();
int[] perechislenie=new int[1000000];
int i=0;
int v=perechislenie.Length;
while (i<v)
{
    perechislenie[i] = i; //заполнили массив числами от 1 до миллиона
    i++;
}
//Console.WriteLine(perechislenie[899999]);
// Заполняем второй массив на 100 000 элементов случайными числами
int[] arrayData=new int[100000];
int v1=arrayData.Length;
i=0;
int temp=0;
while (i<v1)
{
    temp=new Random().Next(0,v);
    if (perechislenie[temp]>0)
    {
        arrayData[i]=temp;
        perechislenie[temp]=-1;
    }
    i++;
}
i=100;
while (i<120)
{
    Console.WriteLine($" , {arrayData[i]}, {i}");
    i++;
}