using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.MealUseCases
{
    public class ProteinsPerMealUseCase
    {
        public double? ProteinPerMealCalculator(List<Food> foodList, List<int> foodWeights)
        {
            double? sum = 0;

            for(int i = 0;i<foodList.Count;i++)
            {
                sum += foodList[i].product!.nutriments!.proteins_100g * foodWeights[i] / 100;
            }

            return sum;
        }
    }
}
