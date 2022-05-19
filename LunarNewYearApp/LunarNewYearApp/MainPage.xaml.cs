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
        Dictionary<string, string> birthStones = new Dictionary<string, string>()
        {
            { "Garnet", "garnet.png"},
            { "Amethyst", "amethyst.png"},
            { "Aquamarine", "aquamarine.png"},
            { "Diamond", "diamond.png"},
            { "Emerald", "emerald.png"},
            { "Alexandrite", "alexandrite.png"},
            { "Ruby", "ruby.png"},
            { "Peridot", "peridot.png"},
            { "Sapphire", "sapphire.png"},
            { "Pink Tourmaline", "pinkTourmaline.png"},
            { "Topaz", "topaz.png"},
            { "Blue Topaz", "blueTopaz.png"}
        };

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Grabs user input from the picker and compares the selected index value
        /// to the dictionary above. Then displays the associated image and gem name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PckrMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = PckrMonths.SelectedIndex;
            string gemName = birthStones.Keys.ElementAt(selectedIndex);
            string gemPath = birthStones.Values.ElementAt(selectedIndex);

            LblBirthStone.Text = $"{gemName}!";
            ImgGems.Source = gemPath;
        }
    }
}
