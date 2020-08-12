using System.ComponentModel;
using Xamarin.Forms;
using Gymen.ViewModels;

namespace Gymen.Views
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