using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myAplication.Models;

namespace myAplication.Pages.Forms
{
    public class CustomPastaModel : PageModel
    {
        [BindProperty]
        public PastasModel Pasta { get; set; }
        public float PastaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PastaPrice = Pasta.BasePrice;
            if (Pasta.TomatoSauce)
            {
                PastaPrice += 20;

            }
            if (Pasta.Cheese)
            {
                PastaPrice += 30;
            }
            if (Pasta.Tuna)
            {
                PastaPrice += 40;
            }
            if (Pasta.Ham)
            {
                PastaPrice += 35;
            }
            if (Pasta.Mushroom)
            {
                PastaPrice += 20;
            }
            return RedirectToPage("/Checkout/Checkout", new {Pasta.PastaName, PastaPrice});
        }
    }
}
