using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.GetFoodByCode
{
    public record GetFoodByCodeResponse(bool Flag, string message = null!, Food food = null!);
}
