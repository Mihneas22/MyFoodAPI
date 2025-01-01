using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.MealUseCases
{
    public class CaloriesPerMealUseCase
    {
        public int? CaloriesPerMealCalculator(List<Food> foodList, List<int> foodWeights)
        {
            int? sum = 0;

            for (int i = 0; i < foodList.Count; i++)
            {
                sum += foodList[i].product!.nutriments!.energy_value * foodWeights[i] / 100;
            }

            return sum;
        }
    }
}
