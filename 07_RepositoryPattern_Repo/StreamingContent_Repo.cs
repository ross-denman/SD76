using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _07_RepositoryPattern_Repo
{
    public class StreamingContent_Repo
    {
        // Repository Pattern: store a private list of items
        private readonly List<StreamingContent> _directory = new List<StreamingContent>();
        // CRUD methods
        // Create
        // Read
        // Update
        // Delete
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _directory.Count;
            // return true or false - did the add method work??
            _directory.Add(content);
            bool wasAdded = _directory.Count > startingCount;
            return wasAdded;
        }
    }
}