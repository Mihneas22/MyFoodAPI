using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.MealUseCases
{
    public class MealCalories100gUseCase
    {
        public int? MealCalories100gCalculator(List<Food> foodList,List<int> foodWeights,int totalWeight)
        {
            int? sumCalories = 0;
            int? sumWeight = 0;

            for (int i = 0; i < foodList.Count; i++)
            {
                sumCalories += foodList[i].product!.nutriments!.energy_value * foodWeights[i] / 100;
                sumWeight += foodWeights[i];
            }

            return 100 * sumCalories / sumWeight;
        }
    }
}
