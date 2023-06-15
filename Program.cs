void Number1()
{
    int[]array=new int[4];
    int count=0;
    Console.Write("[");
    for(int i=0;i<array.Length;i++)
    {
        array[i]=new Random().Next(100,1000);
        if(i==array.Length-1)
        {
            Console.Write(array[i]+"]");
        }
        else
        {
        Console.Write(array[i]+",");
        }
        if(array[i]%2==0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Количество четных чисел: "+count);
}
void Number2()
{
    int[] array2=new int[4];
    int count2=0;
    Console.Write("[");
    for(int i=0;i<array2.Length;i++)
    {
        array2[i]=new Random().Next(1,100);
        if(i==array2.Length-1)
        {
            Console.Write(array2[i]+"]");
        }
        else
        {
        Console.Write(array2[i]+",");
        }
        if(i%2==1)
        {
            count2=count2+array2[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Сумма элементов: "+count2);
}
void Number3()
{
    int[]array3=new int[5];
    int min=0;
    int max=0;
    Console.Write("[");
    for(int i=0;i<array3.Length;i++)
    {
        array3[i]=new Random().Next(1,100);
        if(i==array3.Length-1)
        {
            Console.Write(array3[i]+"]");
        }
        else
        {
        Console.Write(array3[i]+",");
        }
        max =array3[i];
        min =array3[i];
    }
    for(int i=0;i<array3.Length;i++)
    {
        if(array3[i]>max)
        {
            max=array3[i];
        }
        if(array3[i]<min)
        {
            min=array3[i];
        }
    }
    int sum=max-min;
    Console.WriteLine();
    Console.WriteLine("Разница равна: "+sum);
}
Console.WriteLine("Задача 34:");
Number1();
Console.WriteLine();
Console.WriteLine("Задача 36:");
Number2();
Console.WriteLine();
Console.WriteLine("Задача 38:");
Number3();