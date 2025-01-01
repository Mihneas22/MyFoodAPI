using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Repository.AddMeal
{
    public class AddMealDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Nationality { get; set; } = string.Empty;

        [Required]
        public List<string> FoodCodes { get; set; } = new List<string>();

        [Required]
        public List<int> FoodWeight { get; set; } = new List<int>();
    }
}
