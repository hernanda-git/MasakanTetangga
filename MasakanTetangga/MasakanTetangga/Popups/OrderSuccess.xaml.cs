using MasakanTetangga.ViewModels;
using Xamarin.Forms.Xaml;

namespace MasakanTetangga.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderSuccess
    {
        BasePopupViewModel viewModel;
        public OrderSuccess()
        {
            InitializeComponent();
            BindingContext = viewModel = new BasePopupViewModel();
        }
    }
}