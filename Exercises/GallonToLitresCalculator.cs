// Converts gallons per mile to litres per kilometer


Console.WriteLine("Enter gallons/mile: ");

double gallons = 0.0;
string inputData = "";

while (!double.TryParse(inputData, out gallons))
{
    inputData = Console.ReadLine();
}

double litres = (gallons * 3.785) / 1.606;

Console.WriteLine(litres + " litres/kilometer");