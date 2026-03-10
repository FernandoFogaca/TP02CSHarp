using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP02CSharp.Pages.CityManager;

public class CreateCityModel : PageModel
{
    [BindProperty]
    public string CityName { get; set; }

    public void OnPost()
    {

    }
}