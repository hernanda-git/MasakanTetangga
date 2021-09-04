using System.Windows.Input;
using Xamarin.Forms;

namespace MasakanTetangga.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _Username;
        public string Username
        {
            get => _Username;
            set
            {
                _Username = value;
                OnPropertyChanged();
            }
        }

        private string _Password;
        public string Password
        {
            get => _Password;
            set
            {
                _Password = value;
                OnPropertyChanged();
            }
        }
        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);

            DependencyService.Get<IStatusBar>().HideStatusBar();
        }

        public class User
        {
            public static string UserName = "admin";
            public static string Password = "password";
        }

        private void Login()
        {
            if (Username != null || Password != null)
            {
                if (Username != null)
                {
                    if (Password != null)
                    {
                        if (Username == User.UserName && Password == User.Password) RedirectToHomePage();
                        else if (Username != User.UserName) Helpers.XFDialog.SnackBar("User tidak ditemukan.");
                        else Helpers.XFDialog.SnackBar("Password salah.");
                    }
                    else Helpers.XFDialog.SnackBar("Password tidak boleh kosong.");
                }
                else Helpers.XFDialog.SnackBar("Username tidak boleh kosong.");
            }
            else Helpers.XFDialog.SnackBar("Mohon masukkan username dan password.");
        }

        private void RedirectToHomePage()
        {
            App.Current.MainPage = new AppShell();
        }
    }
}
