


// double numberA = new Random().Next(0, 15);
// double numberB = new Random().Next(0, 15);

// System.Console.WriteLine(numberA);
// System.Console.WriteLine(numberB);
// System.Console.WriteLine(numberB / numberA);

// System.Console.Write("Insert your name: ");

// string username = Console.ReadLine();

// if (username.ToLower() == "misha")
// {
//     System.Console.WriteLine("Zdarova Misha orospucucu");
// }
// else
// {
//     System.Console.WriteLine($"Hi, {username}");
// }

Console.Clear();
// Console.SetCursorPosition(10, 4);
// System.Console.WriteLine("*");

int xa = 75, ya = 1,
    xb = 1, yb = 42,
    xc = 150, yc = 42;

Console.SetCursorPosition(xa, ya);
System.Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
System.Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
System.Console.WriteLine("*");


int x = xa, y = xb;

int count = 0;

while (count < 100000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    System.Console.WriteLine("*");
    count += 1;

}
