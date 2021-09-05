using System;
using System.Collections.Generic;
using System.Text;

namespace MasakanTetangga.ViewModels
{
    public class ListMenuViewModel : BaseViewModel
    {

        private string _ImageURL;
        public string ImageURL { get => _ImageURL; set { _ImageURL = value; OnPropertyChanged(); } }
        public ListMenuViewModel()
        {
            ImageURL = "MasakanTetangga.Resources.Images.nasi_ayam_sample.jpg";
        }
    }
}
