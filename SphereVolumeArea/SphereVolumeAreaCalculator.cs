// Calculates area and volume of a sphere

double radius = 0.0;

do
{
    Console.WriteLine("Enter radius of sphere in metres: ");
} while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0.0);

double volume = (4 * Math.PI * Math.Pow(radius, 3.0)) / 3;
double area = 4 * Math.PI * Math.Pow(radius, 2.0);

Console.WriteLine("The volume is: " + volume + " m³ and the area is: " + area);