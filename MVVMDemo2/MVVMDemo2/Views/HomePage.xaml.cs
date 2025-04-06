using MVVMDemo2.Models.ViewModels;

namespace MVVMDemo2.Views;

public partial class HomePage : ContentPage
{
    private ContactsListViewModel contactsViewModel;
    public HomePage()
	{
		InitializeComponent();
		contactsViewModel = new ContactsListViewModel();
        BindingContext = contactsViewModel;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var ContactList = new ContactList();
        ContactList.BindingContext = contactsViewModel;
        Navigation.PushAsync(ContactList);
    }
}