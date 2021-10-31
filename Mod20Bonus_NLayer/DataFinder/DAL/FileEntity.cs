using System;

namespace DataFinder.DAL
{
    public class FileEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public FileEntity(Guid id, string name, string path)
        {
            this.Id = id;
            this.Name = name;
            this.Path = path;
        }
    }
}