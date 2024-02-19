void foo(string[] arr,int index)
{
    Console.Clear();
    for (int i = 0;  i < arr.Length;  i++)
    {
        if(i == index)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(arr[i]);
            Console.ForegroundColor = ConsoleColor.White;

        }
        else Console.WriteLine(arr[i]);

    }
}

string[] variant = { "Next", "Back", "All Show", "Exit" };

int index = 0;

do
{
    switch (index)
    {
        case 0:
            foo(variant, index);
            break;
        case 1:
            foo(variant, index);
            break;
        case 2:
            foo(variant, index);
            break;
        case 3:
            foo(variant, index);
            break;
    }


    ConsoleKeyInfo key = Console.ReadKey(true);

    if (key.Key == ConsoleKey.UpArrow)
    {
        if (index != 0)
            index--;
        else index = 3;
    }

    if (key.Key == ConsoleKey.DownArrow)
    {
        if (index != 3)
            index++;
        else index = 0;
    }

    if (key.Key == ConsoleKey.Enter)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Secilen - {variant[index]}");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    }


} while (true);
