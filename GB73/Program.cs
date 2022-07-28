Console.Clear();

ulong n = Input("Введите число N: ");
ulong[] arrayResult = new ulong[n+1];
ulong groups = 0;

for(ulong count = 1; count<=n; count++)
{
    if(arrayResult[count]!=1)
    {
        groups++;
        Console.Write($"\nГруппа {groups}: {count}");

        arrayResult[count] = 1;
        for(ulong i = count; i<=n; i++)
        {
            if(i%count != 0 && arrayResult[i] != 1)
            {
                Console.Write($", {i}");
                arrayResult[i] = 1;
            }
        }
    }
}

Console.WriteLine("\nВсего для числа " + n + " найдено " + groups + " групп чисел.\n");

ulong Input(string output)
{
    Console.Write(output);
    ulong result = 0;
    while(result < 1)
    {
        result = Convert.ToUInt64(Console.ReadLine());
        if(result < 1 )
        {
            Console.Write("Введите верное значение (оно должно быть больше 0): ");
        }
    }
    return result;
}
