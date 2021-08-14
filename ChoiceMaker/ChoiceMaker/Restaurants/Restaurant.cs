using System;
using System.Collections.Generic;

namespace ChoiceMaker
{
    public class Restaurant
    {
         public double weekDayCloseTime{ get; }
         public double weekendCloseTime { get; }
         public string name { get; }
         public double averageMealPrice { get; }
         public List<FoodType> foodType { get;  }
         public ReadyTime readyTime { get; }


        public Restaurant(string rest_name, double rest_weekDayCloseTime, double rest_weekendCloseTime, double rest_averageMealPrice,
                            List<FoodType> rest_foodTypes, ReadyTime rest_readyTime)
        {

            name = rest_name;
            weekDayCloseTime = rest_weekDayCloseTime;
            weekendCloseTime = rest_weekendCloseTime;
            averageMealPrice = rest_averageMealPrice;
            foodType = rest_foodTypes;
            readyTime = rest_readyTime;

        }



    }
}
