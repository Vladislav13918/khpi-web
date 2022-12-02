namespace lab5.Pages;

using System;
using lab5.Interfaces;

public class XmlRender : IRenderer
{
    public void StartRendering()
    {
        Console.WriteLine("Start XML render");
    }

    public void StopRendering()
    {
        Console.WriteLine("Stop XML render");
    }

    public void RenderString(string @string)
    {
        Console.WriteLine("Render string value into XML");
    }

    public void RenderImage(string Image)
    {
        Console.WriteLine("Render image into XML");
    }
}
