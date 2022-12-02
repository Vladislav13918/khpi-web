namespace lab6;


using lab6.Interfaces;


public class CachedDownloader : IDownloader
{
    private readonly IDownloader _downloader;
    private readonly Dictionary<string, File> _cache;

    public CachedDownloader(IDownloader downloader)
    {
        _downloader = downloader;
        _cache = new Dictionary<string, File>();
    }

    public File Download(string fileName)
    {
        if (_cache.TryGetValue(fileName, out File cachedFile))
        {
            return cachedFile;
        }

        File downloadedFile = _downloader.Download(fileName);
        _cache[fileName] = downloadedFile;

        return downloadedFile;
    }
}
