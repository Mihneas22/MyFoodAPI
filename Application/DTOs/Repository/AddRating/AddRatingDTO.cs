using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Repository.AddRating
{
    public class AddRatingDTO
    {
        [Required]
        public string MealName { get; set; } = string.Empty;

        [Required]
        public string Text { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        [Required, Range(0,5)]
        public double TheRating { get; set; } = 0.0;
    }
}
