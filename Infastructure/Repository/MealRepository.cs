using Application.DTOs.Repository.AddMeal;
using Application.DTOs.Repository.GetMeal;
using Application.DTOs.Repository.GetMealByName;
using Application.Repository;
using Application.Services.GetFoodByCode;
using Domain.Entities;
using Domain.UseCases.MealUseCases;
using Application.DTOs.Services.GetFoodByCode;
using Infastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Repository
{
    public class MealRepository : IMeal
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IFood _foodService;

        public MealRepository(ApplicationDbContext dbContext, IFood foodService)
        {
            _dbContext = dbContext;
            _foodService = foodService;
        }

        public async Task<AddMealResponse> AddMeal(AddMealDTO addMealDTO)
        {
            if (addMealDTO == null)
                return new AddMealResponse(false, "Invalid data entered");

            List<Food> foodList = new List<Food>();

            foreach(string foodCode in addMealDTO.FoodCodes)
            {
                var food = await _foodService.GetFoodByCodeAsync(new GetFoodByCodeDTO { code = foodCode });
                foodList.Add(food.food);
            }

            _dbContext.Add(new Meal
            {
                Name = addMealDTO.Name,
                Description = addMealDTO.Description,
                Nationality = addMealDTO.Nationality,
                FoodCodes = addMealDTO.FoodCodes,
                FoodWeight = addMealDTO.FoodWeight,
                MealTotalWeight = new MealTotalWeightUseCase().MealTotalWeightCalculator(addMealDTO.FoodWeight),
                Calories100g = new MealCalories100gUseCase().MealCalories100gCalculator(foodList, addMealDTO.FoodWeight,new MealTotalWeightUseCase().MealTotalWeightCalculator(addMealDTO.FoodWeight)),
                MealProtein100g = new MealProtein100gUseCase().MealProtein100gCalculator(foodList, addMealDTO.FoodWeight, new MealTotalWeightUseCase().MealTotalWeightCalculator(addMealDTO.FoodWeight)),
                MealCarbs100g = new MealCarbs100gUseCase().MealCarbs100gCalculator(foodList, addMealDTO.FoodWeight, new MealTotalWeightUseCase().MealTotalWeightCalculator(addMealDTO.FoodWeight)),
                MealFats100g = new MealFats100gUseCase().MealFats100gCalculator(foodList,addMealDTO.FoodWeight, new MealTotalWeightUseCase().MealTotalWeightCalculator(addMealDTO.FoodWeight)),
                CaloriesPerMeal = new CaloriesPerMealUseCase().CaloriesPerMealCalculator(foodList, addMealDTO.FoodWeight),
                MealProteinPerMeal = new ProteinsPerMealUseCase().ProteinPerMealCalculator(foodList, addMealDTO.FoodWeight),
                MealCarbsPerMeal = new CarbsPerMealUseCase().CarbsPerMealCalculator(foodList,addMealDTO.FoodWeight),
                MealFatsPerMeal = new FatsPerMealUseCase().FatsPerMealCalculator(foodList,addMealDTO.FoodWeight),
                Rating = 0f,
            });
            await _dbContext.SaveChangesAsync();

            return new AddMealResponse(true, "Succesfull Add");
        }

        public async Task<GetMealByNameResponse> GetMealByName(GetMealByNameDTO getMealByNameDTO)
        {
            if(getMealByNameDTO == null)
                return new GetMealByNameResponse(false, "Invalid name");

            var meal = await _dbContext.MealEntity.FirstOrDefaultAsync(u => u.Name == getMealByNameDTO.Name);

            if(meal == null)
                return new GetMealByNameResponse(false, "Meal not found");

            return new GetMealByNameResponse(false,"Success!",meal);
        }
    }
}
