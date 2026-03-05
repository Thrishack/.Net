using Databinding.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Databinding.Pages
{
    public class DatabindingModel : PageModel
    {
        [BindProperty]
        public Person Person { get; set; }
        public string Result { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            Result = $"Name: {Person.Name}, Age: {Person.Age}, City: {Person.City}";
            }
            }
        }
 