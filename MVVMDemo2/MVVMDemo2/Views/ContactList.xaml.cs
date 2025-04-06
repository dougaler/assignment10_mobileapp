using MVVMDemo2.Models.ViewModels;
using MVVMDemo2.Models;

namespace MVVMDemo2.Views;

public partial class ContactList : ContentPage
{
	public ContactList()
	{
		InitializeComponent();
	}

    private void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var contact = e.Item as Models.Contact;
        var contactViewModel = new ContactDetailViewModel { Contact = contact };
        var contactDetail = new ContactDetail();
        contactDetail.BindingContext = contactViewModel;
        Navigation.PushAsync(contactDetail);

    }
}