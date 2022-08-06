namespace Amnesia.Engine.External;

public static class JS
{
    public static void Alert(string message)
    {
        Pages.Index.IJS?.Void("Alert", message);
    }

    public static void RecolorCanvas(float red, float green, float blue)
    {
        Pages.Index.IJS?.Void("js_recolor_canvas", red, green, blue);
    }
}