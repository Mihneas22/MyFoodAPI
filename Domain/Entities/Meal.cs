using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Nationality {  get; set; }

        public List<string>? FoodCodes { get; set; }

        public List<int>? FoodWeight { get; set; }

        public int? MealTotalWeight { get; set; }

        public float? Calories100g {  get; set; }

        public float? MealProtein100g {  get; set; }

        public float? MealCarbs100g { get; set; }

        public float? MealFats100g {  get; set; }

        public float? CaloriesPerMeal { get; set; }

        public float? MealProteinPerMeal { get; set; }

        public float? MealCarbsPerMeal { get; set; }

        public float? MealFatsPerMeal { get; set; }

        public float? Rating { get; set; }
    }
}
