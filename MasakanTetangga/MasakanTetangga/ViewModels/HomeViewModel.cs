using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MasakanTetangga.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private int _CartCounter;
        public int CartCounter
        {
            get => _CartCounter; set
            {
                _CartCounter = value;
                CartCountVisibility = CartCounter > 0;
                OnPropertyChanged();
            }
        }

        private bool _CartCountVisibility;
        public bool CartCountVisibility
        {
            get => CartCounter > 0;
            set
            {
                _CartCountVisibility = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddRequestComand { get; }
        public HomeViewModel()
        {
            AddRequestComand = new Command(AddRequest);
            CartCounter = 0;
        }

        private void AddRequest()
        {
            CartCounter++;
        }
    }
}
