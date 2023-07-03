using FolderTreeTask.Data;
using FolderTreeTask.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace FolderTreeTask.Controllers
{
    public class FolderController : Controller
    {

        private readonly FoldertaskContext _context;

        public FolderController( FoldertaskContext context )
        {
            _context = context;
        }

        public IActionResult FolderTree(int currentFolderId = 1)
        {
            var currentFolder = _context.Folders.Find(currentFolderId);
            if (currentFolder == null)
            {
                return NotFound();
            }
            var listOfSubfolders = _context.Folders.Where(x => x.RootFolderId == currentFolder.FolderId).ToList();
            FolderModel? model = new FolderModel { Current = currentFolder, Children = listOfSubfolders };
            return View(model);
        }

        public IActionResult Error()
        { 
            return View();
        }
    }
}