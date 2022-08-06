
namespace Amnesia.Game;
static class Main
{
    public static async Task Run()
    {
        await Task.Delay(10);

        Amnesia.Engine.External.JS.RecolorCanvas(1,0,0);
    }
}