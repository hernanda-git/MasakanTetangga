using System.Windows.Input;
using Xamarin.Forms;
using Rg.Plugins.Popup.Extensions;

namespace MasakanTetangga.ViewModels
{
    public class BasePopupViewModel : Rg.Plugins.Popup.Pages.PopupPage
    {
        private bool _AllCaps;
        public bool AllCaps { get => _AllCaps; set { _AllCaps = value; OnPropertyChanged(); } }

        public ICommand ChangeCapsCommand { get; }
        public ICommand TakeOrderCommand { get; }
        public BasePopupViewModel()
        {
            ChangeCapsCommand = new Command(changeCaps);
            TakeOrderCommand = new Command(TakeOrder);
        }

        private void TakeOrder()
        {
            Application.Current.MainPage.Navigation.PopAllPopupAsync();
            Application.Current.MainPage.Navigation.PushPopupAsync(new Popups.OrderSuccess());
        }

        private void changeCaps()
        {
            AllCaps = !AllCaps;
        }
    }
}
