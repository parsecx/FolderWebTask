using System;
using System.Collections.Generic;

namespace FolderTreeTask.Data;

public partial class Folder
{
    public int FolderId { get; set; }

    public string Name { get; set; } = null!;

    public int? RootFolderId { get; set; }
}
