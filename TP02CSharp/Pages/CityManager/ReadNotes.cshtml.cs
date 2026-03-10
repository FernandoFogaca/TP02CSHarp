using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP02CSharp.Pages.CityManager;

public class ReadNotesModel : PageModel
{
    public List<string> Notes { get; set; } = new();
   

    public string Content { get; set; }
 

    public void OnGet(string fileName)
    {
        var folder = Path.Combine("wwwroot", "files");
                                                       

        if (Directory.Exists(folder))
        {
            Notes = Directory.GetFiles(folder, "*.txt")
                .Select(Path.GetFileName)
                .ToList();
        }

      
        if (!string.IsNullOrEmpty(fileName))
        {
            var fullPath = Path.Combine(folder, fileName);

            if (System.IO.File.Exists(fullPath))
            {
                Content = System.IO.File.ReadAllText(fullPath);
            }
        }
    }
}