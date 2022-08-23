internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfGrannies;
        int interval = 10;
        int totalTime;
        int remainHours;
        int remainMinutes;        

        Console.Write("Введите количество старушек в очереди: ");
        numberOfGrannies = Convert.ToInt32(Console.ReadLine());

        totalTime = numberOfGrannies * interval;
        remainHours = totalTime / 60;
        remainMinutes = totalTime % 60;

        Console.WriteLine($"Вам придётся отстоять в очереди {remainHours} часов и {remainMinutes} минут");
    }
}