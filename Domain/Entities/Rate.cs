using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Rate
    {
        [Key]
        public int Id { get; set; }

        public string? MealName {  get; set; }

        public string? Text { get; set; }

        public string? Author { get; set; }

        public double? TheRating { get; set; }
    }
}
