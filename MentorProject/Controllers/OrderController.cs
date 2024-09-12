using MentorProject.Contexts;
using MentorProject.Models;
using MentorProject.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorProject.Controllers
{
    public class OrderController : Controller
    {
        private readonly BookTechDbContext _context;
        public OrderController()
        {
            _context = new BookTechDbContext();
        }
        public async Task<IActionResult> IndexAsync()
        {
            var orders = await _context.Orders

                .Select(x => new Order
                {
                    Id = x.Id,
                    OrderNumber = x.OrderNumber,
                    OrderDate = x.OrderDate,
                    OrderTotalPrice = x.OrderTotalPrice
                })
                .ToListAsync();
            return View(orders);
        }


        [HttpGet]
        public async Task<IActionResult> AddOrder()
        {
            Order order = new();
            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return View(order);
        }
    }
}
