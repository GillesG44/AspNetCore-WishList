using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly IEnumerable<Item> _items;

        public ItemController(IEnumerable<Item> items)
        {
            _items = items;
        }

        public IActionResult Index()
        {
            return View(_items.ToList());
        }
    }
}
