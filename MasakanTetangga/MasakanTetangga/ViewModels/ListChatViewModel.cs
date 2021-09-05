using System;
using System.Collections.Generic;
using System.Text;

namespace MasakanTetangga.ViewModels
{
    public class ListChatViewModel : BaseViewModel
    {

        private string _ImageURL;
        public string ImageURL { get => _ImageURL; set { _ImageURL = value; OnPropertyChanged(); } }
        public ListChatViewModel()
        {
            ImageURL = "MasakanTetangga.Resources.Images.Avatar.zendaya.jpg";
        }
    }
}
