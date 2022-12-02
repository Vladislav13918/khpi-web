namespace lab5.Pages;

using System;
using lab5.Interfaces;

public class HtmlRender : IRenderer
{
    public void StartRendering()
    {
        Console.WriteLine("Start HTML render");
    }

    public void StopRendering()
    {
        Console.WriteLine("Stop HTML render");
    }

    public void RenderString(string @string)
    {
        Console.WriteLine("Render string value into HTML");
    }

    public void RenderImage(string Image)
    {
        Console.WriteLine("Render image into HTML");
    }
}
