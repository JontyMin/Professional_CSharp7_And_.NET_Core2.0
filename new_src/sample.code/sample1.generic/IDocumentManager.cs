namespace sample1.generic
{
    public interface IDocumentManager<T>
    {
        void AddDocument(T doc);

        T GetDocument();

        void DisplayAllDocuments();
    }
}