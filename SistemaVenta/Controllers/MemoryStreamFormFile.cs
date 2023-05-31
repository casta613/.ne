
namespace SistemaVenta.Controllers
{
    public class MemoryStreamFormFile : IFormFile
    {
        private readonly Stream _stream;
        private readonly long _length;
        private readonly string _fileName;

        public MemoryStreamFormFile(Stream stream, long length, string fileName, string contentType = null)
        {
            _stream = stream;
            _length = length;
            _fileName = fileName;
            ContentType = contentType;
        }

        public string ContentType { get; }

        public string ContentDisposition => $"form-data; name=\"file\"; filename=\"{_fileName}\"";

        public IHeaderDictionary Headers => new HeaderDictionary();

        public long Length => _length;

        public string Name => "file";

        public string FileName { get; }

        public void CopyTo(Stream target)
        {
            throw new NotImplementedException();
        }

        public Task CopyToAsync(Stream target, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Stream OpenReadStream()
        {
            return _stream;
        }
    }
}