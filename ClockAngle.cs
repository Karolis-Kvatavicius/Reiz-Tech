public class ClockAngle
{
    public static void countClockAngle()
    {
        try
        {
            Console.WriteLine("Enter hours:");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minutes:");
            int minutes = Convert.ToInt32(Console.ReadLine());

            if (hours > 0 && hours <= 12 && minutes >= 0 && minutes < 60)
            {

                // each minute angle between handles increases by 0.5 degrees
                double angle = 0.5 * (60 * hours + minutes);

                //check to always return the smaller angle
                if (angle > 180)
                {
                    angle = Math.Abs(360 - angle);
                }
                Console.WriteLine("The lesser angle is " + angle);
            }
            else
            {
                Console.WriteLine("Please enter valid time.");
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Please enter whole numbers only.");
        }
    }
}