using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myAplication.Data;
using myAplication.Models;

namespace myAplication.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        
        public string PastaName { get; set; }
        public float PastaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context=context;   
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PastaName))
            {
                PastaName = ImageTitle;
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "customPasta";
            }

            PastaOrder pastaOrder = new PastaOrder();
            pastaOrder.PastaName = PastaName;
            pastaOrder.BasePrice = PastaPrice;

            _context.PastaOrders.Add(pastaOrder);
            _context.SaveChanges();
        }
    }
}
