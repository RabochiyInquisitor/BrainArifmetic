using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System.Threading;
using MyTest;
using System.Text;
using Microsoft.Maui.ApplicationModel.Communication;


namespace MyTest;

public partial class Settings : ContentPage
{
    public ViewModel viewModel;
    public Settings(ViewModel viewModel)
	{
        viewModel = new ViewModel();
        InitializeComponent();
        
	}
	//private async void changeLevel1(object sender, EventArgs e)
	//{
	//	var button = sender as Button;
    //
    //    await Navigation.PushAsync(new MainPage());
	//	
	//}
    //private async void changeLevel2(object sender, EventArgs e)
    //{
    //    
    //}
    //private async void changeLevel3(object sender, EventArgs e)
    //{
    //    var button = sender as Button;
    //
    //    await Navigation.PushAsync(new MainPage()
    //    {
    //
    //        BindingContext = 1
    //    });
    //}
    private void changeTheme1(object sender, CheckedChangedEventArgs e)
    {
        LocalStorage.SetValue("black");
    }
    private void changeTheme2(object sender, CheckedChangedEventArgs e)
    {
        LocalStorage.SetValue("red");
    }
    private void changeTheme3(object sender, CheckedChangedEventArgs e)
    {
        LocalStorage.SetValue("green");
    }
    private void changeTheme4(object sender, CheckedChangedEventArgs e)
    {
        LocalStorage.SetValue("yellow");

    }       

}