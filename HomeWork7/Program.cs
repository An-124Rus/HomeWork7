internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfGrannies;
        int patientWaitingTime = 10;
        int totalTime;
        int hoursInQueue;
        int minutesInQueue;
        int minutesInHour = 60;

        Console.Write("Введите количество старушек в очереди: ");
        numberOfGrannies = Convert.ToInt32(Console.ReadLine());

        totalTime = numberOfGrannies * patientWaitingTime;
        hoursInQueue = totalTime / minutesInHour;
        minutesInQueue = totalTime % minutesInHour;

        Console.WriteLine($"Вам придётся отстоять в очереди {hoursInQueue} часов и {minutesInQueue} минут");
    }
}