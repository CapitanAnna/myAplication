using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myAplication.Models;

namespace myAplication.Pages.Forms
{
    public class CustomPastaModel : PageModel
    {
        [BindProperty]
        public PastasModel Pasta { get; set; }
        public float PastaPrices { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PastaPrices = Pasta.BasePrice;
            if (Pasta.TomatoSauce)
            {
                Pasta.TotalPrice += 20;

            }
            if (Pasta.Cheese)
            {
                Pasta.TotalPrice += 30;
            }
            if (Pasta.Tuna)
            {
                Pasta.TotalPrice += 40;
            }
            if (Pasta.Ham)
            {
                Pasta.TotalPrice += 35;
            }
            if (Pasta.Mushroom)
            {
                Pasta.TotalPrice += 20;
            }
            return RedirectToPage("/Checkout/Checkout", new {Pasta.PastaName, PastaPrices});
        }
    }
}
