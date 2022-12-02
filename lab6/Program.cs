namespace lab6;

using lab6.Interfaces;


public class Program
{
    public static void Main(string[] args)
    {
        IDownloader cachedDownloader = new CachedDownloader(new SimpleDownloader());

        cachedDownloader.Download("file");
        cachedDownloader.Download("file");
    }
}
