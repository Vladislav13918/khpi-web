namespace lab6;

using System;
using lab6.Interfaces;


public class SimpleDownloader : IDownloader
{
    public File Download(string fileName)
    {

        return new File
        {
            FileName = fileName,
        };
    }
}
