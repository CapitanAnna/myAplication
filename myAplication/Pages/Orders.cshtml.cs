using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myAplication.Data;
using myAplication.Models;

namespace myAplication.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PastaOrder> PastaOrders = new List<PastaOrder>();
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context=context;
        }
        public void OnGet()
        {
            PastaOrders=_context.PastaOrders.ToList();
        }
    }
}
