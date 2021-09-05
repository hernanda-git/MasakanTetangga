using MasakanTetangga.ViewModels;
using Xamarin.Forms.Xaml;

namespace MasakanTetangga.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListChat : BaseView
    {
        ListChatViewModel viewModel;
        public ListChat()
        {
            InitializeComponent();
            BindingContext = viewModel = new ListChatViewModel();
        }
    }
}