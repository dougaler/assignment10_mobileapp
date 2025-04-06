
using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMDemo2.Models.ViewModels;

partial class ContactDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private Contact contact;
}
