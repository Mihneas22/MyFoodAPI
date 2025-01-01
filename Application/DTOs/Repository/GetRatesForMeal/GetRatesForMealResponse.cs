using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Repository.GetRatesForMeal
{
    public record GetRatesForMealResponse(bool Flag, string message = null!, List<Rate> rates = null!);
}
