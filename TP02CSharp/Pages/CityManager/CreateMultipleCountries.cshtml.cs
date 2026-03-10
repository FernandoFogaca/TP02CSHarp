using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP02CSharp.Pages.CityManager;

public class CreateMultipleCountriesModel : PageModel
{
    [BindProperty]
    public List<InputModel> Countries { get; set; } = new();
    

    public List<InputModel> SubmittedCountries { get; set; } = new();


    public class InputModel
    {
        public string CountryName { get; set; }
      

        public string CountryCode { get; set; }
      
    }

    public void OnGet()
    {
   
        for (int i = 0; i < 5; i++)
        {
            Countries.Add(new InputModel());
        }
    }

    public void OnPost()
    {
       
        SubmittedCountries = Countries;
    }
}