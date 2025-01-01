using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.MealUseCases
{
    public class MealTotalWeightUseCase
    {
        public int MealTotalWeightCalculator(List<int> foodWeights)
        {
            return foodWeights.Sum();
        }
    }
}
