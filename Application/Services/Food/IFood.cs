using Application.DTOs.Services.GetFoodByCode;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.GetFoodByCode
{
    public interface IFood
    {
        Task<GetFoodByCodeResponse> GetFoodByCodeAsync(GetFoodByCodeDTO getFoodByCodeDTO);
    }
}
