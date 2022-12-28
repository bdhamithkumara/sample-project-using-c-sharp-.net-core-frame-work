using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practice01.Model;

namespace practice01.Pages
{
    public class productModel : PageModel
    {
        public List<BreadModel> BreadModels = new List<BreadModel>()
        {
            new BreadModel(){ BreadName="crusty french bread",ImageName="crustyfrenchbread",BreadPrice=25,BreadSize="Medium"},
            new BreadModel(){ BreadName="Gluten Bread",ImageName="GlutenBread",BreadPrice=35,BreadSize="Small"},
            new BreadModel(){ BreadName="milk bread",ImageName="milkbread",BreadPrice=45,BreadSize="Large"},
            new BreadModel(){ BreadName="mixed Seeded Bread",ImageName="mixedSeededBread",BreadPrice=85,BreadSize="Large"},
            new BreadModel(){ BreadName="Sandwich White",ImageName="SandwichWhite",BreadPrice=85,BreadSize="Large"},

        };

        public void OnGet()
        {
        }

    }
}
