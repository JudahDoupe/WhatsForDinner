using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WhatsForDinner.Models;

namespace WhatsForDinner.Pages
{
    [BindProperties]
    public class PlanModel : PageModel
    {
        public List<Recipe> Recipes { get; set; }

        public void OnGet()
        {

            Recipes = new List<Recipe>
            {
                new Recipe
                {
                    Name = "Pasta",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Amount = 2,
                            Measurement = "cups",
                            Type = "water"
                        },
                        new Ingredient
                        {
                            Amount = 1,
                            Measurement = "box",
                            Type = "spaghetti"
                        }
                    }
                },
                new Recipe
                {
                    Name = "Pasta",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Amount = 2,
                            Measurement = "cups",
                            Type = "water"
                        },
                        new Ingredient
                        {
                            Amount = 1,
                            Measurement = "box",
                            Type = "spaghetti"
                        }
                    }
                },
                new Recipe
                {
                    Name = "Pasta",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Amount = 2,
                            Measurement = "cups",
                            Type = "water"
                        },
                        new Ingredient
                        {
                            Amount = 1,
                            Measurement = "box",
                            Type = "spaghetti"
                        }
                    }
                },
                new Recipe
                {
                    Name = "Pasta",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Amount = 2,
                            Measurement = "cups",
                            Type = "water"
                        },
                        new Ingredient
                        {
                            Amount = 1,
                            Measurement = "box",
                            Type = "spaghetti"
                        }
                    }
                },
                new Recipe
                {
                    Name = "Pasta",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Amount = 2,
                            Measurement = "cups",
                            Type = "water"
                        },
                        new Ingredient
                        {
                            Amount = 1,
                            Measurement = "box",
                            Type = "spaghetti"
                        }
                    }
                },
            };
        }
    }
}