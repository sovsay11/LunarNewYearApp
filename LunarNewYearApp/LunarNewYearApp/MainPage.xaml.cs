using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LunarNewYearApp
{
    /// <summary>
    /// MODIFY ALL THIS TO USE ANIMALS INSTEAD
    /// </summary>
    public partial class MainPage : ContentPage
    {
        // Dictionary holds image paths and associated birthstones
        Dictionary<string, string> animals = new Dictionary<string, string>()
        {
            { "Monkey", "monkey.png"},
            { "Rooster", "rooster.png"},
            { "Dog", "dog.png"},
            { "Pig", "pig.png"},
            { "Rat", "rat.png"},
            { "Ox", "ox.png"},
            { "Tiger", "tiger.png"},
            { "Rabbit", "rabbit.png"},
            { "Dragon", "dragon.png"},
            { "Snake", "snake.png"},
            { "Horse", "horse.png"},
            { "Goat", "goat.png"},
        };

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Whenever the user presses enter (the complete key), grab the
        /// year and figure out which animal belongs to it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EntYear_Completed(object sender, EventArgs e)
        {
            // Grab the year
            int year = 0;
            try
            {
                year = int.Parse(EntYear.Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter a valid number!", "Close");
            }
            
            // Convert the year to a numerical value to use in the dictionary
            int index = year % 12;

            // Display results
            string animalName = animals.Keys.ElementAt(index);
            string animalPath = animals.Values.ElementAt(index);

            LblAnimal.Text = $"{animalName}";
            ImgAnimal.Source = animalPath;
        }
    }
}
