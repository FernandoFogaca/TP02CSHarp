using System.ComponentModel.DataAnnotations; 
using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Mvc.RazorPages; 

namespace TP02CSharp.Pages.CityManager; 

public class CreateCityValidationModel : PageModel 
{
    [BindProperty] 
    public InputModel Input { get; set; } 

    public string ResultMessage { get; set; } 

    public class InputModel 
    {
        [Required(ErrorMessage = "City name is required")] 
        [MinLength(3, ErrorMessage = "City name must contain at least 3 characters")] 
        public string CityName { get; set; } 
    }

    public void OnPost() 
    {
        if (!ModelState.IsValid) 
        {
            return; 
        }

        ResultMessage = $"The city submitted was: {Input.CityName}"; 
    }
}