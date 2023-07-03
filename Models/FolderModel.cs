using FolderTreeTask.Data;

namespace FolderTreeTask.Models
{
    public class FolderModel
    {
        public Folder Current { get; set; } = new Folder();
        public List<Folder> Children { get; set; } = new List<Folder>();
    }
}
