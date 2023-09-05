// Calculates the points in a diving contest

using System.Numerics;

while (true)
{
    double difficulty = 0.0;
    double[] points = { 0, 0, 0, 0, 0 };
    double temporarySum = 0.0;
    double score = 0.0;

    // Input for difficulty, check that is is a double
    do
    {
        Console.WriteLine("Enter difficulty: ");
    } while (!double.TryParse(Console.ReadLine(), out difficulty));

    // Input for all five judges points, check that is is a double
    for (int i = 0; i < 5; i++)
    {
        do
        {
            Console.WriteLine("Enter points: ");
        } while (!double.TryParse(Console.ReadLine(), out points[i]));
    }

    // Sort the points in ascending order
    Array.Sort(points);

    // Add all except for lowest and higest score into a temporary sum
    for (int i = 1; i < 4; i++)
    {
        temporarySum = temporarySum + points[i];
    }

    // Calculate and print the score
    score = (temporarySum * difficulty) / 3;
    Console.WriteLine("Score= " + score);
}