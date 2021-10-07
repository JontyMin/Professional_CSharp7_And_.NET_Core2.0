using System;
using System.Collections.Generic;
using System.Data.Common;

namespace sample1.generic
{
    public class DocumentManager<T> : IDocumentManager<T> where T : IDocument
    {
        private readonly Queue<T> _documentQueue = new Queue<T>();
        private readonly object _lock = new object();

        public bool IsAvailable => _documentQueue.Count > 0;

        public void AddDocument(T doc)
        {
            lock (_lock)
            {
                _documentQueue.Enqueue(doc);
            }
        }

        public T GetDocument()
        {
            T doc = default;
            lock (_lock)
            {
                doc = _documentQueue.Dequeue();
            }

            return doc;
        }

        public void DisplayAllDocuments()
        {
            foreach (var doc in _documentQueue)
            {
                Console.WriteLine(doc.Title);
            }
        }
    }
}