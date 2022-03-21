using PrjPam.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PrjPam.Views
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