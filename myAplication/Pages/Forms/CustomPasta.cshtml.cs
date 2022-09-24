using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myAplication.Models;

namespace myAplication.Pages.Forms
{
    public class CustomPastaModel : PageModel
    {
        [BindProperty]
        public PastasModel Pasta { get; set; }
        public void OnGet()
        {
        }
    }
}
