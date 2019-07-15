using System;

class ClockAngle
{
  static void Main()
  {
    Console.WriteLine("What's the hour?");
    int hourInt = int.Parse(Console.ReadLine());

    Console.WriteLine("What's the minute?");
    int minInt = int.Parse(Console.ReadLine());

    float result = determineDistance(hourInt, minInt);

    Console.WriteLine("The distance in degrees between the minute and hoir is: " + result + " degress!");
  }

  static float determineDistance(int hour, int minute)
  {
    float minDegrees = minute * 6;
    float hourDegrees = Convert.ToSingle(hour * 30 + .5 * minute);
    float diffAngle = Math.Abs(minDegrees - hourDegrees);
    if (diffAngle > 180)
    {
      diffAngle = 360 - diffAngle;
    }
    return diffAngle;
  }
}
