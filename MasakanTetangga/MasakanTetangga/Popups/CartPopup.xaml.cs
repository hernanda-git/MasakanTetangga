using MasakanTetangga.ViewModels;
using Xamarin.Forms.Xaml;

namespace MasakanTetangga.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPopup
    {
        BasePopupViewModel viewModel;
        public CartPopup()
        {
            InitializeComponent();
            BindingContext = viewModel = new BasePopupViewModel();
        }
    }
}