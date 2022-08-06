export function AmnesiaInit() {
    DotNet.invokeMethodAsync("Amnesia", "Init");
}

export function OnKeyDown() {
    DotNet.invokeMethodAsync("Amnesia", "OnKeyDown");
}

export function OnKeyUp() {
    DotNet.invokeMethodAsync("Amnesia", "OnKeyUp");
}