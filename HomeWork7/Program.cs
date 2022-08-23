internal class Program
{
    private static void Main(string[] args)
    {
        int oneHour;
        int oneMinute = 1;        
        int numberOfGrannies;
        int timeForOneGranny = 10;
        int totalTime;
        int hoursInQueue;
        int minutesInQueue;        

        Console.Write("Введите количество старушек в очереди: ");
        numberOfGrannies = Convert.ToInt32(Console.ReadLine());

        oneHour = oneMinute * 60;
        totalTime = numberOfGrannies * timeForOneGranny;
        hoursInQueue = totalTime / oneHour;
        minutesInQueue = totalTime % oneHour;

        Console.WriteLine($"Вам придётся отстоять в очереди {hoursInQueue} часов и {minutesInQueue} минут");
    }
}