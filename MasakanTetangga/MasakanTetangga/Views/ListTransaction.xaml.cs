using MasakanTetangga.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasakanTetangga.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListTransaction : BaseView
    {
        ListTransactionViewModel viewModel;
        public ListTransaction()
        {
            InitializeComponent();
            BindingContext = viewModel = new ListTransactionViewModel();
        }
    }
}