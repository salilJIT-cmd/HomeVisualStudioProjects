using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebAPI_1.Models
{
    public class RegisterCredits
    {
        // This class is made for the sole purpose of learning built-in attributes
        // for validation of a property

        // For more info - https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-7.0#built-in-attributes



        public int Id{ get; set; }

        [Phone]
        public int Phone { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Age should be >= 0 and <= 100")]
        public int Age {  get; set; }


        [Range(typeof(DateTime), "1/1/1923", "1/1/2023")]
        public DateTime DOB { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [StringLength(20, ErrorMessage = "Password length should not be greater than 20")]
        public string Password { get; set; }


        [Compare(nameof(Password), ErrorMessage = "Passwords does not match")]
        public string ConfirmPassword { get; set; }



        //Note - 
        // It is important to use the [FromBody] attribute to make the validations work
        //eg - public ActionResult AddEmployee([FromBody] Employee employee)

        // Explanation ->
        // by using [FromBody], you specify the format of the data you're expecting,
        // and this can make a significant difference in how model binding and validation
        // are performed in your ASP.NET Core action.
        // It ensures that the JSON data is correctly mapped to your model and
        // that the validation rules are applied as intended.


    }
}
