using System.ComponentModel;
using Xamarin.Forms;
using gitdemo2.ViewModels;

namespace gitdemo2.Views
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