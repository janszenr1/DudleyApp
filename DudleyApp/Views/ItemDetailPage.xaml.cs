using System.ComponentModel;
using DudleyApp.ViewModels;
using Xamarin.Forms;

namespace DudleyApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}