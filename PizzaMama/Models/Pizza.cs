using System;
namespace PizzaMama.Models
{
	public class Pizza
	{
        internal string nom;
        internal int prix;

        public int PizzaId { get; set; }
		public string Nom { get; set; }
		public float Prix { get; set; }
		public bool Vegetarien { get; set; }
		public string Ingredient { get; set; }
	}
}

