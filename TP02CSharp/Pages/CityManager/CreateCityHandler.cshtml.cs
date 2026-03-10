using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP02CSharp.Pages.CityManager;

public class CreateCityHandlerModel : PageModel
{
    public string Message { get; set; }

    public void OnPost(string cityName)
    {
        Message = $"The city submitted was: {cityName}";
    }
}