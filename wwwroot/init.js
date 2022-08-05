window.AmnesiaInit = () => {
    DotNet.invokeMethodAsync("Amnesia", "Init");
}

Blazor.start().then(function () {
    AmnesiaInit();
});