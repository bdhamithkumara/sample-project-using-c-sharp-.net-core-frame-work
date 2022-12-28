using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace practice01.Pages
{
    [BindProperties(SupportsGet =true)]
    public class ThankYouModel : PageModel
    {
        public string  BreadName { get; set; }
        public string Imagename { get; set; }
        public string BreadSize { get; set; }
        public void OnGet()
        {
        }
    }
}
