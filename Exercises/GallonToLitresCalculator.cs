// Converts gallons per mile to litres per kilometer

double gallons;

do
{
    Console.WriteLine("Enter gallons/mile: ");
} while (!double.TryParse(Console.ReadLine(), out gallons));

double litres = (gallons * 3.785) / 1.606;

Console.WriteLine(litres + " litres/kilometer");