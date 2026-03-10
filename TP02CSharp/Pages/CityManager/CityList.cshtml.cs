using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP02CSharp.Pages.CityManager;

public class CityListModel : PageModel
{
    public List<string> Cities { get; set; } = new()
    {
        "London",
        "Manchester",
        "Liverpool"
    };
   
}