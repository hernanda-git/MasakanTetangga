using MasakanTetangga.ViewModels;
using Xamarin.Forms.Xaml;

namespace MasakanTetangga.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListMenu : BaseView
    {
        ListMenuViewModel viewModel;
        public ListMenu()
        {
            InitializeComponent();
            BindingContext = viewModel = new ListMenuViewModel();
        }
    }
}