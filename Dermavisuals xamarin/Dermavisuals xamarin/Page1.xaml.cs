using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dermavisuals_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        string[] Quotes = {
    "The only way to do great work is to love what you do. - Steve Jobs",
    "In the end, we will remember not the words of our enemies, but the silence of our friends. - Martin Luther King Jr",
    "Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill"};

        Color[] Colors = { Color.Red, Color.Blue, Color.Orange, Color.Green, Color.Purple, Color.Brown };
        int number = 0;

        public Page1()
        {
            InitializeComponent();
            
        }
 
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (number >= 0 && number < Quotes.Length) {
                number++;
            };
            if(number < 0 || number >= Quotes.Length)
            {
                number = 0;
            }
            
            QuoteLabel.Text = Quotes[number];
        }

        private void sliderColor_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            QuoteLabel.TextColor = Colors[((int)e.NewValue)];
        }
    }
}