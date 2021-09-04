using MasakanTetangga.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(StatusBarImplementation))]
namespace MasakanTetangga.iOS
{
    public class StatusBarImplementation : IStatusBar
    {
        public StatusBarImplementation()
        {
        }

        #region IStatusBar implementation

        public void HideStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = true;
        }

        public void ShowStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = false;
        }

        #endregion
    }
}