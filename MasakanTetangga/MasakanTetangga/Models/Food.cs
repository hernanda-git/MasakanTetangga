
using System;

namespace MasakanTetangga.Models
{
    public record Food
    {
        public int FoodId { get; set; }
        public int UserId { get; set; }
        public string UserAvatarURL { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
