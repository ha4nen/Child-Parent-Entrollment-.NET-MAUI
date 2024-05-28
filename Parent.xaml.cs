using MauiApp1.Models;

namespace MauiApp1;

public partial class Parent : ContentPage
{
	public Parent()
	{
		InitializeComponent();
        P_List_View.ItemsSource = App.DBTrans.GetAllParents();

    }


    private void Gender_RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender == Male_RadioButton && e.Value)
        {
            Female_RadioButton.IsChecked = false;
        }
        else if (sender == Female_RadioButton && e.Value)
        {
            Male_RadioButton.IsChecked = false;
        }
    }
    private void Button_Add_Clicked(object sender, EventArgs e)
    {
        string gender = null;
        if (Male_RadioButton.IsChecked)
        {
            gender = "Mother";
        }
        else if (Female_RadioButton.IsChecked)
        {
            gender = "Female";
        }
        App.DBTrans.AddP(new Models.ParentsClass
        {
            P_Name = P_Name.Text,
            P_L_Name = P_L_Name.Text,
            P_Tel = P_Tel.Text,
            P_Mother_Father = gender,

        });
        P_List_View.ItemsSource = App.DBTrans.GetAllParents();

        P_Name.Text = string.Empty;
        P_L_Name.Text = string.Empty;
        P_Tel.Text = string.Empty;
        Male_RadioButton.IsChecked = false;
        Female_RadioButton.IsChecked = false;
    }



    private void Button_delete_Clicked(object sender, EventArgs e)
    {
        if (Global.selectedParent != null)
        {
            App.DBTrans.DeleteP(Global.selectedParent.P_Id);

            P_List_View.ItemsSource = App.DBTrans.GetAllParents();


            Global.selectedParent = null;

            DisplayAlert("Success", "parent deleted successfully.", "OK");
        }
        else
        {
            DisplayAlert("Error", "No parent selected.", "OK");
        }
    }
    private void P_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Global.selectedParent = e.Item as ParentsClass;
    }
}