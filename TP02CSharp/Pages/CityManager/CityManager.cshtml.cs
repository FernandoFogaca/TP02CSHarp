using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using TP02CSharp.Models;

namespace TP02CSharp.Pages.CityManager;

public class CreateCountryCustomValidationModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }
   

    public Country CreatedCountry { get; set; }


    public class InputModel
    {
        [Required]
        public string CountryName { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 2)]
        public string CountryCode { get; set; }
    }

    public void OnPost()
    {
        if (!ModelState.IsValid)
        {
            return;
        }

       
        if (!Input.CountryName.StartsWith(Input.CountryCode[0]))
        {
            ModelState.AddModelError(
                "Input.CountryCode",
                "The country code must start with the same letter as the country name."
            );

            return;
        }

        CreatedCountry = new Country
        {
            CountryName = Input.CountryName,
            CountryCode = Input.CountryCode
        };
    }
}