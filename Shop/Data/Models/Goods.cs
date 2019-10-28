using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Goods
    {
        public int id { set; get; } //просто айди товара
        public string name { set; get; }    //имя товара
        public string shortDesc { set; get; }   //короткое описание товара
        public string longDesc { set; get; }    //полное описание товара
        public string img { set; get; }     //фото товара
        public ushort price { set; get; }   //цена товара(цена не может быть минус)
        public bool isFavourite { set; get; }   //товар на главной страничке или нет(в вкладке лучшие товары)
        public bool available { set; get; }  //есть ли данный товар на складе и сколько ед.
        public int categoryID { set; get; } //какое поле категории
        public virtual Category Category { set; get; }  //на основе этого, мы создаем обьект со всеми значениями из модели Category 


    }
}
