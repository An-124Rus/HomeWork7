internal class Program
{
    private static void Main(string[] args)
    {
        int hour;
        int minute = 1;        
        int numberOfGrannies;
        int interval = 10;
        int totalTime;
        int hoursInQueue;
        int minutesInQueue;        

        Console.Write("Введите количество старушек в очереди: ");
        numberOfGrannies = Convert.ToInt32(Console.ReadLine());

        hour = minute * 60;
        totalTime = numberOfGrannies * interval;
        hoursInQueue = totalTime / hour;
        minutesInQueue = totalTime % hour;

        Console.WriteLine($"Вам придётся отстоять в очереди {hoursInQueue} часов и {minutesInQueue} минут");
    }
}