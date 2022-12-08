namespace Proxy
{
    public class Document
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
}