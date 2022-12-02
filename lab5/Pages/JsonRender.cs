namespace lab5.Pages;

using System;
using lab5.Interfaces;

public class JsonRender : IRenderer
{
    public void StartRendering()
    {
        Console.WriteLine("Start JSON render");
    }

    public void StopRendering()
    {
        Console.WriteLine("Stop JSON render");
    }

    public void RenderString(string @string)
    {

        Console.WriteLine("Render string value into JSON");
    }

    public void RenderImage(string Image)
    {
        Console.WriteLine("Render image into JSON");
    }
}
