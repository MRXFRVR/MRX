/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Package
{
public string Description { get; set; }
public double Weight { get; set; }

public Package(string description, double weight)
{
Description = description;
Weight = weight;
}
}

class DeliveryService
{
private double weightLimit;
private double totalWeight;

public DeliveryService(double limit)
{
weightLimit = limit;
totalWeight = 0;
}

public void SendPackage(Package package)
{
if (totalWeight + package.Weight > weightLimit)
{
Console.WriteLine("Превышен лимит веса отправленных посылок.");
}
else
{
totalWeight += package.Weight;
Console.WriteLine($"Посылка \"{package.Description}\" отправлена.");
}
}
}

class Program
{
static void Main()
{
DeliveryService postService = new DeliveryService(100);
Package package1 = new Package("Книга", 20);
Package package2 = new Package("Одежда", 40);
Package package3 = new Package("Аксессуары", 50);

postService.SendPackage(package1);
postService.SendPackage(package2);
postService.SendPackage(package3);
}
}
