using Microsoft.AspNetCore.Mvc; 


using Microsoft.AspNetCore.Mvc.RazorPages; 


using TP02CSharp.Models; 


namespace TP02CSharp.Pages.CityManager; 


public class CreateCountryModel : PageModel 

{
    [BindProperty] 


    public InputModel Input { get; set; } 


    public Country CreatedCountry { get; set; } 


    public class InputModel 

    {
        public string CountryName { get; set; } 
 

        public string CountryCode { get; set; } 
   
    }

    public void OnPost() 
     
    {
        CreatedCountry = new Country 
         
            {
                CountryName = Input.CountryName, 
               

                CountryCode = Input.CountryCode 
               
            };
    }
}