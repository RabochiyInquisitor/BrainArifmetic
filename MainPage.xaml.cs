using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System.Threading;
using MyTest;
using System.Text;
using System.Web;

namespace MyTest
{
    public partial class MainPage : ContentPage
    {
       
        public static int Value;
        public static string Sample;
        private ViewModel viewModel;
        public MainPage()
        {

            InitializeComponent();
            viewModel = new ViewModel();
            BindingContext = viewModel;
            var arr = ChangeText(150, 240, 10, 150);
            MainPage.Value = arr.Item2;
            MainPage.Sample = arr.Item1;
            //MyTask.Text = arr.Item1;
            string data = LocalStorage.GetValue();
            
            
            
            
        }
        private async void Settings(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings(viewModel));
            
        }
        public (string, int) ChangeText(int min = 150, int max = 240, int min2 = 10, int max2 = 150)
        {
            char[] symbols = { '+', '-', '×', '/' };
            Random numbers = new Random();
            int id = numbers.Next(0, 2);
            int value1 = numbers.Next(min, max);
            int value2 = numbers.Next(min2, max2);
            char oper = symbols[id];
            string output = Convert.ToString(value1) + Convert.ToString(oper) + Convert.ToString(value2);
            switch (oper)
            {
                case '+':
                    {
                        int res = value1 + value2;
                        return (output, res);
                    }
                case '-':
                    {
                        int res = value1 - value2;
                        return (output, res);
                    }
                case '×':
                    {
                        int res = value1 * value2;
                        return (output, res);
                    }
                case '/':
                    {
                        int res = value1 / value2;
                        return (output, res);
                    }
                default:
                    return (output, 0);
            }
        }
        private void Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            Place.Text += button.Text;
        }
        private void Del(object sender, EventArgs e)
        {
            try
            {
                string result = Place.Text.Substring(0, Place.Text.Length - 1);
                Place.Text = result;
            }
            catch
            {

            }
        }
        private async void Done(object sender, EventArgs e)
        {
            if (Convert.ToString(MainPage.Value) == Convert.ToString(Place.Text))
            { 
                MyTask.Text = "Верно!";
                await Task.Delay(1000);
                var arr = ChangeText(150, 240, 10, 150);
                MainPage.Value = arr.Item2;
                MyTask.Text = arr.Item1;
                Place.Text = string.Empty;

                
            }
            else
            {
                MyTask.Text = "Неверно!";
                await Task.Delay(1000);
                var arr = ChangeText(150, 240, 10, 150);
                MainPage.Value = arr.Item2;
                MyTask.Text = arr.Item1;
                Place.Text = string.Empty;
            }
        }
    }
}