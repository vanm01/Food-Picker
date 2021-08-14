using System;
using System.Collections.Generic;

namespace ChoiceMaker
{

    public class RestaurantsList
    {

        public List<Restaurant> restaurants = new List<Restaurant>();

        public List<FoodType> paneraList = new List<FoodType>();
        public List<FoodType> chipotleList = new List<FoodType>();
        public List<FoodType> burgerKingList = new List<FoodType>();
        public List<FoodType> mcdonaldsList = new List<FoodType>();
        public List<FoodType> pandaList = new List<FoodType>();
        public List<FoodType> chickList = new List<FoodType>();
        public List<FoodType> subwayList = new List<FoodType>();
        public List<FoodType> papaList = new List<FoodType>();

        public RestaurantsList()
        {


            //Add Restaurants
            //Panera
            paneraList.Add(FoodType.Breakfast);
            paneraList.Add(FoodType.Healthy);
            paneraList.Add(FoodType.Sandwich);
            restaurants.Add(new Restaurant("Panera", 75600, 75600, 35.00, paneraList, ReadyTime.SitIn));

            

            //Chipotle
            chipotleList.Add(FoodType.Healthy);
            restaurants.Add(new Restaurant("Chipotle", 79200, 79200, 30, chipotleList, ReadyTime.FastFood));



            //Burger king
            burgerKingList.Add(FoodType.Burger);
            burgerKingList.Add(FoodType.Chicken);
            restaurants.Add(new Restaurant("Burger King", 82800, 82800, 28, burgerKingList, ReadyTime.FastFood));



            //McDonalds
            mcdonaldsList.Add(FoodType.Burger);
            mcdonaldsList.Add(FoodType.Chicken);
            restaurants.Add(new Restaurant("McDonalds", 90000, 90000, 24, mcdonaldsList, ReadyTime.FastFood));




            //Panda
            pandaList.Add(FoodType.Chinese);
            restaurants.Add(new Restaurant("Panda", 64800, 0, 18, pandaList, ReadyTime.SitIn));




            //Chick-fil-a
            chickList.Add(FoodType.Chicken);
            restaurants.Add(new Restaurant("Chick-fil-a", 79200, 79200, 28, chickList, ReadyTime.FastFood));


            //Subway
            subwayList.Add(FoodType.Healthy);
            subwayList.Add(FoodType.Sandwich);
            restaurants.Add(new Restaurant("Subway", 90000, 90000, 28, subwayList, ReadyTime.FastFood));



            //Pappa Johns
            papaList.Add(FoodType.Pizza);
            restaurants.Add(new Restaurant("Pappa Johns", (24 * 3600), (24 * 3600), 30, papaList, ReadyTime.FastFood));
        }
    }

}
