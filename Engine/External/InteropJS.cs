using Microsoft.JSInterop;
namespace Amnesia.Engine.External;

public class JavaScript
{
    private readonly IJSRuntime js;

    public JavaScript(IJSRuntime js)
    {
        this.js = js;
    }

    public async ValueTask Void(string methodName, params object?[]? args)
    {
        await js.InvokeVoidAsync(methodName, args);
    }

    public void Dispose()
    {

    }
}