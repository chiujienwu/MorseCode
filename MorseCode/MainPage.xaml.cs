using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    public partial class MainPage : ContentPage
    {
        public string output;
        public string morse;
        public string input;

        public MainPage()
        {
            InitializeComponent();
        }

        public void But_Dot (object sender, EventArgs e)
        {
            input += ((Button)sender).Text;

            Output_Morse.Text += input;
        }

        public void But_Dash(object sender, EventArgs e)
        {
            input += ((Button)sender).Text;

            Output_Morse.Text += input;
        }

        public void But_Space(object sender, EventArgs e)
        {

            try
            {
                char letter = Morse.MorseCoder(input);
                Output_Letter.Text += letter;
                Output_Morse.Text += " ";
                input = "";

            } catch (Exception)
            {
                DisplayAlert("Error Occurred", "Oops" , "OK");
            }
        }
    }
}
