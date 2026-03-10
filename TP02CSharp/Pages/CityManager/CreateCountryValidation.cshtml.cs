using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP02CSharp.Models;

namespace TP02CSharp.Pages.CityManager;

public class CreateCountryValidationModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public Country CreatedCountry { get; set; }

    public class InputModel
    {
        [Required(ErrorMessage = "Country name is required")]
        public string CountryName { get; set; }

        [StringLength(2, MinimumLength = 2, ErrorMessage = "Country code must contain exactly 2 letters")]
        public string CountryCode { get; set; }
    }

    public void OnPost()
    {
        if (!ModelState.IsValid)
        {
            return;
        }

        CreatedCountry = new Country
        {
            CountryName = Input.CountryName,
            CountryCode = Input.CountryCode
        };
    }
}