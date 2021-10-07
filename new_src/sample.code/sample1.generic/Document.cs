namespace sample1.generic
{
    public class Document:IDocument
    {
        public Document(string title,string content)
        {
            this.Title = title;
            this.Content = content;
        }
        public string Title { get; }
        public string Content { get; }
    }
}