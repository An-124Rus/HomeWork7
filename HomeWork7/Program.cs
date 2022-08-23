internal class Program
{
    private static void Main(string[] args)
    {
        int granny;
        int interval = 10;
        int totalTime;
        int minutes;
        int hour;

        Console.Write("Введите количество старушек в очереди: ");
        granny = Convert.ToInt32(Console.ReadLine());

        totalTime = granny * interval;
        hour = totalTime / 60;
        minutes = totalTime % 60;

        Console.WriteLine($"Вам придётся отстоять в очереди {hour} часов и {minutes} минут");
    }
}