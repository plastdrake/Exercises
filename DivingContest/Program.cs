// Calculates the points in a diving contest

using System.Numerics;

double difficulty = 0.0;
double [] points = {0, 0, 0, 0, 0 };
string firstInputData = "";
string secondInputData = "";
double parsedData = 0.0;
int counter = 0;
double temporarySum = 0.0;
double score = 0.0;


while (!double.TryParse(firstInputData, out difficulty))
{
    Console.WriteLine("Enter difficulty: ");
    firstInputData = Console.ReadLine();
    difficulty = double.Parse(firstInputData);
}

while (!double.TryParse(secondInputData, out parsedData) && counter < 5)
{
    Console.WriteLine("Enter points: ");
    secondInputData = Console.ReadLine();
    parsedData = double.Parse(secondInputData);
    points[counter] = parsedData;
    secondInputData = "";
    counter++;
}

Array.Sort(points);

for (int i = 1; i < 4; i++)
{
    temporarySum = temporarySum + points[i];
}

score = (temporarySum * difficulty) / 3;
Console.WriteLine("Score= " + score);