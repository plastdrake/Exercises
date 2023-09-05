// Helps the user pick an insurance plan for their car

using System;

int currentYear = 0;
int yearOfMake = 0;
string firstInputData = "";
string secondInputData = "";
bool validYear = false;

// Input for current year, check that it is an integer
while (!int.TryParse(firstInputData, out currentYear))
{
    Console.WriteLine("Enter current year: ");
    firstInputData = Console.ReadLine();
}

// Input for manufactured year, check that it is an integer and that it is after the invention of cars
while (!int.TryParse(secondInputData, out yearOfMake) || !validYear)
{
    Console.WriteLine("Enter year of make: ");
    secondInputData = Console.ReadLine();
    yearOfMake = int.Parse(secondInputData);

    if (yearOfMake < 1885)
    {
        Console.WriteLine("The car was invented 1885! ");
    }
    else
    {
        validYear = true;
    }
}

int age = currentYear - yearOfMake;

if (age < 5)
{
    Console.WriteLine("Get the full-premium insurance!");
}
else if (age < 25)
{
    Console.WriteLine("Get the half-premium insurance!");
}
else
{
    Console.WriteLine("Get the veteran insurance!");
}