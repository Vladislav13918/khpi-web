namespace lab2.Interfaces;

public interface IStorage
{
    void Write(string fileName, byte[] bytes);
    byte[] Read(string fileName);
}
