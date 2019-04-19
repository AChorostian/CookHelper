using System.Collections.Generic;
using CookHelper.Models;

namespace CookHelper.ViewModels
{
    public class RecipesViewModel
    {
        public List<Recipe> RecipesCollection { get; set; }

        public RecipesViewModel()
        {
            RecipesCollection = new List<Recipe>
            {
                new Recipe { Name="Jajecznica" },
                new Recipe { Name="Naleśniki" }
            };

            RecipesCollection.Sort();
        }
    }
}
