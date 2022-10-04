using TASK8IP;

bool stillMore;
double cRadius;

do
{
    Console.Write("Please, enter radius: ");
    string received = Console.ReadLine();
    while (!Double.TryParse(received, out cRadius) || cRadius<0)
    {
        Console.Write("Not valid, try again: ");
        received = Console.ReadLine();
    }
    //Now you can create an object of type Circle:
    //Call your constructor:
    Circle circle=new Circle(cRadius);

    //Console.WriteLine("Area of the circle is {0:F3} square units.", circle.CalculateArea());
    //Console.WriteLine("Circumference is {0:F3}.", circle.CalculateCircumference());
    


    Console.Write("More of this (Y/N): ");
    string decision = Console.ReadLine().ToUpper();
    if (decision.StartsWith("Y"))
        stillMore = true;
    else
        stillMore = false;
} while (stillMore);