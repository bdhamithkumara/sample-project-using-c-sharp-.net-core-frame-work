using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practice01.Model;

namespace practice01.Pages
{
    public class CustomOrderModel : PageModel
    {
        [BindProperty]

        public BreadModel Bread { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/ThankYou", new { Bread.BreadName, Bread.ImageName, Bread.BreadSize });
        }
    }
}
