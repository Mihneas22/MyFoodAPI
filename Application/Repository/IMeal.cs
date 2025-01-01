using Application.DTOs.Repository.AddMeal;
using Application.DTOs.Repository.AddRating;
using Application.DTOs.Repository.GetMeal;
using Application.DTOs.Repository.GetMealByName;
using Application.DTOs.Repository.GetRatesForMeal;
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
    
        //Rates
        Task<AddRatingResponse> AddRatingForMeal(AddRatingDTO addRatingDTO);

        Task<GetRatesForMealResponse> GetRatesForMeal(GetRatesForMealDTO getRatesForMealDTO);
    }
}
