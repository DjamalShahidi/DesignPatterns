namespace Proxy
{
    public interface IDocument
    {
        void DisplayDocument();
    }

    public class Document : IDocument
    {

        public string _fileName;
        public Document(string fileName)
        {
            _fileName = fileName;
            LoadDocument(fileName);
        }
        public string? Title { get; private set; }
        public string? Content { get; private set; }
        public int AuthorId { get; private set; }
        public DateTimeOffset LastAccessed { get; private set; }


        private void LoadDocument(string fileName)
        {
            Console.WriteLine("Excuting expensive action:loading a file from disk");

            Thread.Sleep(1000);

            Title = "An expensive document";
            Content = "Lots and lots of content";
            AuthorId = 1;
            LastAccessed = DateTimeOffset.UtcNow;
        }

        public void DisplayDocument()
        {
            Console.WriteLine($"Title: {Title},Content: {Content}");
        }


    }

    public class DocumentProxy : IDocument
    {
        private Document? _document;
        private string _fileName;

        public DocumentProxy(string fileName)
        {
            _fileName = fileName;
        }
        public void DisplayDocument()
        {
            if (_document == null)
            {
                _document = new Document(_fileName);
            }

            _document.DisplayDocument();
        }
    }

    //Lazy
    public class LazyDocumentProxy : IDocument
    {
        private Lazy<Document> _document;
        private string _fileName;

        public LazyDocumentProxy(string fileName)
        {
            _fileName = fileName;
            _document = new Lazy<Document>(() => new Document(_fileName));
        }
        public void DisplayDocument()
        {
            _document.Value.DisplayDocument();
        }
    }


    public class ProtectedDocumentProxy : IDocument
    {
        private string _fileName;
        private string _userRole;
        private DocumentProxy _documentProxy;
        public ProtectedDocumentProxy(string fileName, string userRole)
        {
            fileName = _fileName;
            _userRole = userRole;
            _documentProxy = new DocumentProxy(_fileName);
        }

        public void DisplayDocument()
        {
            Console.WriteLine($"Entring DisplayDocument in {nameof(ProtectedDocumentProxy)}");

            if (_userRole != "Viewer")
            {
                throw new UnauthorizedAccessException();
            }

            _documentProxy.DisplayDocument();

            Console.WriteLine($"Exiting DisplayDocument in {nameof(ProtectedDocumentProxy)}");

        }
    }
}