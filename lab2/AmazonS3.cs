namespace lab2;

using lab2.Interfaces;

public class AmazonS3 : Singleton<AmazonS3>, IStorage
{
    public AmazonS3()
    {
        Console.WriteLine($"{nameof(AmazonS3)} ctor");
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
