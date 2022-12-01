namespace lab2;

using lab2.Interfaces;

public class LocalFile : Singleton<LocalFile>, IStorage
{
    public LocalFile()
    {
        Console.WriteLine($"{nameof(LocalFile)} ctor");
    }

    public void Write(string fileName, byte[] bytes)
    {
        throw new System.NotImplementedException();
    }

    public byte[] Read(string fileName)
    {
        throw new System.NotImplementedException();
    }
}
