/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Orc
{
public static int TotalGoldCarried { get; private set; } = 0;
public int GoldCarried { get; private set; }

public Orc()
{
if (TotalGoldCarried == 0)
{
GoldCarried = 2;
TotalGoldCarried += 2;
}
else if (TotalGoldCarried > 0 && TotalGoldCarried < 10)
{
GoldCarried = 2;
TotalGoldCarried += 2;
}
else if (TotalGoldCarried >= 10)
{
GoldCarried = TotalGoldCarried > 5 ? 0 : 2;
TotalGoldCarried += GoldCarried - 2;
}
}
}

class Program
{
static void Main()
{
Orc orc1 = new Orc();
Console.WriteLine($"Orc 1 has {orc1.GoldCarried} gold, Total: {Orc.TotalGoldCarried} gold");

Orc orc2 = new Orc();
Console.WriteLine($"Orc 2 has {orc2.GoldCarried} gold, Total: {Orc.TotalGoldCarried} gold");

Orc orc3 = new Orc();
Console.WriteLine($"Orc 3 has {orc3.GoldCarried} gold, Total: {Orc.TotalGoldCarried} gold");

Orc orc4 = new Orc();
Console.WriteLine($"Orc 4 has {orc4.GoldCarried} gold, Total: {Orc.TotalGoldCarried} gold");

Orc orc5 = new Orc();
Console.WriteLine($"Orc 5 has {orc5.GoldCarried} gold, Total: {Orc.TotalGoldCarried} gold");

Orc orc6 = new Orc();
Console.WriteLine($"Orc 6 has {orc6.GoldCarried} gold, Total: {Orc.TotalGoldCarried} gold");
}
}