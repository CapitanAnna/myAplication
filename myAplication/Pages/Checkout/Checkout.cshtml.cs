using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace myAplication.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        
        public string PastaName { get; set; }
        public float PastaPrice { get; set; }
        public string ImageTitle { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PastaName))
            {
                PastaName = "customPasta";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "customPasta";
            }
        }
    }
}
