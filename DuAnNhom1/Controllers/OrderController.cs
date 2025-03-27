using DuAnNhom1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DuAnNhom1.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Checkout()
        {
            var order = new Order { OrderDate = DateTime.Now, TotalPrice = 100 }; // Demo
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }

}
