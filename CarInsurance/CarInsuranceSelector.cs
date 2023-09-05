// Helps the user pick an insurance plan for their car

int currentYear = 0;
int yearOfMake = 0;

// Input for current year, check that it is an integer
do
{
    Console.WriteLine("Enter current year: ");
} while (!int.TryParse(Console.ReadLine(), out currentYear));

// Input for manufactured year, check that it is an integer and that it is after the invention of cars
do
{
    Console.WriteLine("Enter year of make: ");
} while (!int.TryParse(Console.ReadLine(), out yearOfMake) || yearOfMake < 1885 || yearOfMake > currentYear);

// Calculate age of the car
int age = currentYear - yearOfMake;

// Suggest insurance plan depending on age of the car
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