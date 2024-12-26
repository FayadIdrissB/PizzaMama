using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PizzaMama.Data;
using PizzaMama.Models;

namespace PizzaMama.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        DataContext  dataContext;

        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext dataContext)
        {
            _logger = logger;
            this.dataContext = dataContext;
        }

        public void OnGet()
        {
         /*   var pizza = new Pizza() {
                Nom = "PizzaVégétarien",
                Prix = 10,
                Vegetarien = true,
                Ingredient = "Sauce Crème, Fromage, Falafel, Oeuf, Choukchouka"
            };
            dataContext.Pizzas.Add(pizza);
            dataContext.SaveChanges();  */
        }
    }
}

