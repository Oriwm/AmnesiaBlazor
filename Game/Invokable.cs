using Amnesia.Engine.External;
using Microsoft.JSInterop;

namespace Amnesia.Game;
public interface Invokable
{
    [JSInvokable]
    public static void OnKeyDown()
    {
        Random random = new();
        JS.RecolorCanvas(random.NextSingle(), random.NextSingle(), random.NextSingle());
    }

    [JSInvokable]
    public static void OnKeyUp()
    {
        Random random = new();
        JS.RecolorCanvas(random.NextSingle(), random.NextSingle(), random.NextSingle());
    }
}
