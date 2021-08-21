using System.ComponentModel;
using Xamarin.Forms;
using Xamarindemo.ViewModels;

namespace Xamarindemo.Views
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