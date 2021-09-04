namespace MasakanTetangga.Helpers
{
    public static class XFDialog
    {
        public static async void SnackBar(string message)
        {
            await XF.Material.Forms.UI.Dialogs.MaterialDialog.Instance.SnackbarAsync(message);
        }
    }
}
