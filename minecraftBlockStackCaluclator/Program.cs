using System.Diagnostics.Metrics;

bool again = true;

while(again == true)
{
    int measurement1 = 0;
    int measurement2 = 0;
    int measurement3 = 0;

    Console.Write("Please give your first measurement: ");
    measurement1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please give your second measurement: ");
    measurement2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please give your third measurement (if none put 1): ");
    measurement3 = Convert.ToInt32(Console.ReadLine());

    int total = measurement1 * measurement2 * measurement3;
    int stack = total / 64;
    int chest = stack / 27;

    Console.WriteLine("\n\nTOTAL BLOCKS: " + total);

    Console.WriteLine("STACKS (64 BLOCKS): " + stack);

    Console.WriteLine("EXCESS BLOCKS (in blocks): " + total % 64);

    Console.WriteLine("SINGLE CHESTS: " + chest);

    Console.WriteLine("EXCESS BLOCKS (in stacks): " + stack % 27);

    if (chest > 0)
    {
        Console.WriteLine("\nYou will need " + chest + " single chest(s) full of blocks, " + stack % 27 + " stack(s) of block(s) left over that could not be fit in a chest, and " + total % 64 + " excess block(s) left over");
    }
    else if (stack > 0)
    {
        Console.WriteLine("\nYou will need " + stack + " stack(s), and " + total % 64 + " block(s)");
    }
    else
    {
        Console.WriteLine("\nyou will need " + total + " block(s)");
    }


    Console.Write("\n\nDo you want to make another calculation? ");
    if (Console.ReadLine().ToUpper() == "NO")
    {
        again = false;
    }
}
