using MasakanTetangga.Helpers;
using MasakanTetangga.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MasakanTetangga.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        #region Components
        private ObservableCollection<Food> _ObservableFood;
        public ObservableCollection<Food> ObservableFood
        {
            get => _ObservableFood;
            set
            {
                _ObservableFood = value;
                OnPropertyChanged();
            }
        }

        private Food _FoodEntity;
        public Food FoodEntity { get => _FoodEntity; set { _FoodEntity = value; OnPropertyChanged(); } }
        public List<Food> PendingCart { get; set; }

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
        public bool CartCountVisibility
        {
            get => CartCounter > 0;
            set
            {
                OnPropertyChanged();
            }
        }

        public ICommand AddRequestComand { get => new Command((e) => { AddRequest((Food)e); }); }

        #endregion

        public HomeViewModel()
        {
            //initialize components
            SetInitialize();

            //dynamically binding food observable collection
            FoodGeneration();
        }

        private void SetInitialize()
        {
            CartCounter = 0;
            PendingCart = new List<Food>();
        }

        public void FoodGeneration()
        {
            //generate a constant list. this will be replaced by database/api binding
            List<Food> foods = new List<Food>();
            foods.Add(new Food { UserId = 0, UserAvatarURL = "MasakanTetangga.Resources.Images.Avatar.alfred_molina.png", Title = "Nasi Uduk + Ayam Goreng", CreatedBy = "Alfred Molina", CreatedDate = DateTime.Now, FoodId = 1, ImageURL = "MasakanTetangga.Resources.Images.nasi_ayam_sample.jpg", Price = 25000 });
            foods.Add(new Food { UserId = 1, UserAvatarURL = "MasakanTetangga.Resources.Images.Avatar.zendaya.jpg", Title = "Ayam Bakar (Tanpa Nasi)", CreatedBy = "Zendaya", CreatedDate = DateTime.Now, FoodId = 2, ImageURL = "MasakanTetangga.Resources.Images.ayam_bakar_tanpa_nasi.jpg", Price = 35000 });
            foods.Add(new Food { UserId = 0, UserAvatarURL = "MasakanTetangga.Resources.Images.Avatar.alfred_molina.png", Title = "Ayam Goreng + Kentang", CreatedBy = "Alfred Molina", CreatedDate = DateTime.Now, FoodId = 3, ImageURL = "MasakanTetangga.Resources.Images.ayam_goreng_kentang.jpg", Price = 19000 });
            foods.Add(new Food { UserId = 2, UserAvatarURL = "MasakanTetangga.Resources.Images.Avatar.benedict_cumberbatch.jpg", Title = "Klepon", CreatedBy = "Benedict Cumberbatch", CreatedDate = DateTime.Now, FoodId = 4, ImageURL = "MasakanTetangga.Resources.Images.falafel_food.jpg", Price = 17000 });
            foods.Add(new Food { UserId = 3, UserAvatarURL = "MasakanTetangga.Resources.Images.Avatar.tom_holland.jpg", Title = "Misro", CreatedBy = "Tom Holland", CreatedDate = DateTime.Now, FoodId = 5, ImageURL = "MasakanTetangga.Resources.Images.misro.jpg", Price = 5000 });
            foods.Add(new Food { UserId = 3, UserAvatarURL = "MasakanTetangga.Resources.Images.Avatar.tom_holland.jpg", Title = "Holland Roti", CreatedBy = "Tom Holland", CreatedDate = DateTime.Now, FoodId = 6, ImageURL = "MasakanTetangga.Resources.Images.roti_holland.jpg", Price = 23000 });

            //binding list to observable collection
            ObservableFood = new ObservableCollection<Food>(foods);
        }

        public void AddRequest(Food food)
        {
            if(food != null)
            {
                CartCounter++;
                PendingCart.Add(food);
                XFDialog.SnackBar("Berhasil memasukan menu ke keranjang!");
            }
        }
    }
}
