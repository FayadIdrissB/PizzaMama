using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PizzaMama.Models
{
	public class Pizza
	{
		/*internal string nom;
		internal int prix; */

        public int PizzaId { get; set; }
        public string Nom { get; set; }
		public float Prix { get; set; }

        [Display(Name = "Végétarien")]
        public bool Vegetarien { get; set; }

        [Display(Name = "Ingrédient")]
        public string Ingredient { get; set; }
	}
}

