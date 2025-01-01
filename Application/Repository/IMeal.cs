using Application.DTOs.Repository.AddMeal;
using Application.DTOs.Repository.GetMeal;
using Application.DTOs.Repository.GetMealByName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface IMeal
    {
        Task<AddMealResponse> AddMeal(AddMealDTO addMealDTO);

        Task<GetMealByNameResponse> GetMealByName(GetMealByNameDTO getMealByNameDTO);
    }
}
