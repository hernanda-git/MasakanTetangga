using MasakanTetangga.ViewModels;
using Xamarin.Forms.Xaml;

namespace MasakanTetangga.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : BaseView
    {
        LoginViewModel viewModel;
        public Login()
        {
            InitializeComponent();
            BindingContext = viewModel = new LoginViewModel(); 
        }
    }
}