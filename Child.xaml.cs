using MauiApp1.Models;

namespace MauiApp1;

public partial class Child : ContentPage
{
	public Child()
	{
		InitializeComponent();
        C_List_View.ItemsSource = App.DBTrans.GetAllChild();

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
            gender = "Male";
        }
        else if (Female_RadioButton.IsChecked)
        {
            gender = "Female";
        }
        App.DBTrans.AddC(new Models.ChildClass
        {
            C_Name = C_Name.Text,
            C_L_Name = C_L_Name.Text,
            C_Gender = gender

        });
        C_List_View.ItemsSource = App.DBTrans.GetAllChild();

        C_Name.Text = string.Empty;
        C_L_Name.Text = string.Empty;
        Male_RadioButton.IsChecked = false;
        Female_RadioButton.IsChecked = false;
    }



    private void Button_delete_Clicked(object sender, EventArgs e)
    {
        if (Global.selectedChild != null)
        {
            App.DBTrans.DeleteC(Global.selectedChild.C_Id);

            C_List_View.ItemsSource = App.DBTrans.GetAllChild();


            Global.selectedChild = null;

            DisplayAlert("Success", "Child deleted successfully.", "OK");
        }
        else
        {
            DisplayAlert("Error", "No Child selected.", "OK");
        }
    }
    private void C_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Global.selectedChild = e.Item as ChildClass;
    }

}