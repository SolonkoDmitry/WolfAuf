using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;

namespace GGS.Domain
{
    public class Game
    {
        public Game(int iD, string name, string shortDesc, string description, int priceRub, string imageURL)
        {
            ID = iD;
            Name = name;
            ShortDesc = shortDesc;
            Description = description;
            PriceRub = priceRub;
            ImageURL = imageURL;
        }

        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Краткое описание")]
        public string ShortDesc { get; set; }

        [Display(Name = "Полное описание")]
        public string Description { get; set; }

        [Display(Name = "Цена (руб)")]
        public int PriceRub { get; set; }

        [Display(Name = "Ссылка на исходное изображение")]
        public string ImageURL { get; set; }

        public IList<Category> Categories { get; set; }

        public IList<Section> Sections { get; set; }
    }
}
