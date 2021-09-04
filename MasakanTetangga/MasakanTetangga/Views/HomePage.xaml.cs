using MasakanTetangga.ViewModels;
using Xamarin.Forms.Xaml;

namespace MasakanTetangga.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : BaseView
    {
        HomeViewModel viewModel;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new HomeViewModel();
        }
    }
}