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

        public double? Calories100g {  get; set; }

        public double? MealProtein100g {  get; set; }

        public double? MealCarbs100g { get; set; }

        public double? MealFats100g {  get; set; }

        public double? CaloriesPerMeal { get; set; }

        public double? MealProteinPerMeal { get; set; }

        public double? MealCarbsPerMeal { get; set; }

        public double? MealFatsPerMeal { get; set; }

        public List<Rate>? Rates { get; set; }
        public double? Rating { get; set; }
    }
}
