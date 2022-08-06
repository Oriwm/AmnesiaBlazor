using Amnesia.Engine.External;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Amnesia.Engine
{
    public class BlazorBase : ComponentBase, Amnesia.Game.Invokable
    {
        [JSInvokable]
        public static async Task Init()
        {
            await Amnesia.Game.Main.Run();
        }

    }
}
