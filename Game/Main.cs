namespace Amnesia;
static class Main
{
    public static async Task Run()
    {
        Console.WriteLine("Pain initialization...");
        await Task.Delay(2000);
        Console.WriteLine("Pain RUN...");

        Bob myBob = new Bob("Enginer");
        myBob.Say();

        await Task.Delay(2000);
        Console.WriteLine("Pain close...");

        Pages.Index.IJS?.Void("Alert", "Hello, its Amnesia!");
    }
}

class Bob
{
    public string Job;

    public Bob(string job)
    {
        Job = job;
    }

    public void Say()
    {
        Console.WriteLine("My job is " + Job);
    }
}