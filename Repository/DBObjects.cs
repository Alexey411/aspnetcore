using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA20.Models;

namespace WA20.Repository
{
    public class DBObjects
    {

        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Realty.Any())
            {
                content.AddRange(
                     new Realty
                     {
                         room = "2-комнатная",
                         floor = "4 этаж из 15",
                         squares = "79м²",
                         metro = "м.Алабинская",
                         adress = "улица Митерева, дом 85, кв 128",
                         img = "img/home.jpg",
                         price = 3400000,
                         shortDesc = "Очень хорошая квартира.",
                         longDesc = "Дом находится на южной стороне",
                         phone = "12345678900",
                         isFavourite = true,
                         Category = Categories["Вторички"]
                     },
                    new Realty
                    {
                        room = "1-комнатная",
                        floor = "17 этаж из 38",
                        squares = "49м²",
                        metro = "м.Гагарина",
                        adress = "улица Ленинградская, дом 17, кв 350",
                        img = "img/home2.webp",
                        price = 2600000,
                        shortDesc = "Очень хорошая квартира.",
                        longDesc = "Дом находится на южной стороне",
                        phone = "12345678900",
                        isFavourite = true,
                        Category = Categories["Новостройки"]
                    },
                    new Realty
                    {
                        room = "3-комнатная",
                        floor = "19 этаж из 24",
                        squares = "140м²",
                        metro = "м.Победа",
                        adress = "улица Дальняя, дом 57, кв 192",
                        img = "img/home3.jfif",
                        price = 5600000,
                        shortDesc = "Очень хорошая квартира.",
                        longDesc = "Дом находится на южной стороне",
                        phone = "12345678900",
                        isFavourite = true,
                        Category = Categories["Новостройки"]
                    },
                     new Realty
                     {
                         room = "1-комнатная",
                         floor = "30 этаж из 30",
                         squares = "51м²",
                         metro = "м.Спортивная",
                         adress = "улица Московская шоссе, дом 10, кв 350",
                         img = "img/home4.webp",
                         price = 6600000,
                         shortDesc = "Очень хорошая квартира.",
                         longDesc = "Дом находится на южной стороне",
                         phone = "12345678900",
                         isFavourite = true,
                         Category = Categories["Вторички"]
                     },
                      new Realty
                      {
                          room = "офис",
                          floor = "77 этаж из 78",
                          squares = "251м²",
                          metro = "м.Московское",
                          adress = "улица Московская шоссе, дом 10, офис 350",
                          img = "img/office.jpg",
                          price = 6600000,
                          shortDesc = "Очень хороший офис.",
                          longDesc = "Офис с хорошим ремонтом",
                          phone = "12345678900",
                          isFavourite = true,
                          Category = Categories["Коммерческая"]
                      }
                    );
            }
            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {   
                         new Category{ categoryName = "Вторички"},
                         new Category{ categoryName = "Новостройки"},
                         new Category{ categoryName = "Коммерческая"},
                         new Category{ categoryName = "Аренда"},
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
