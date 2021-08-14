using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ChoiceMaker
{
    public partial class MainPage : ContentPage
    {

        FoodType foodTypeChoice;

        ReadyTime readyTimeChoice;

        TimeSpan time;

        double convertedTime;

        RestaurantsList rest_List = new RestaurantsList();

        List<Restaurant> choices = new List<Restaurant>();

        string choiceNames;

        public MainPage()
        {
            InitializeComponent();

        }

        void typePicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            foodTypeChoice = (FoodType)typePicker.SelectedItem;

            Console.WriteLine(foodTypeChoice);
        }

        void readyTimePicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            readyTimeChoice = (ReadyTime)readyTimePicker.SelectedItem;

            Console.WriteLine(readyTimeChoice);
        }

        void findRest_Clicked(System.Object sender, System.EventArgs e)
        {
            choiceNames = "";
            choices.Clear();

            time = DateTime.Now.TimeOfDay;

            convertedTime = (time.Hours * 3600) + (time.Minutes * 60);

            foreach(Restaurant restaurant in rest_List.restaurants)
            {
                if (convertedTime < restaurant.weekDayCloseTime)
                {
                    if (readyTimeChoice == restaurant.readyTime)
                    {

                        foreach (FoodType fType in restaurant.foodType)
                        {

                            if (foodTypeChoice == fType)
                            {
                                choices.Add(restaurant);
                                choiceNames = restaurant.name + "," + choiceNames;
                            }

                        }

                    }
                }
            }

            result.Text = choiceNames;

        }
    }
}
