using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA20.interfaces;
using WA20.Models;

namespace WA20.mocks
{
    public class MockRealty : IAllRealty
    {
        private readonly IRealtyCategory _categoryRealty = new MockCategory();
        public IEnumerable<Realty> Realty
        {
            get
            {
                return new List<Realty>
                {
                    new Realty{ room="2-комнатная",
                        floor="4 этаж из 15",
                        squares="79м²",
                        metro="м.Алабинская",
                        adress="улица Митерева, дом 85, кв 128",
                        img="img/home.jpg",
                        price=3400000,
                        shortDesc="Очень хорошая квартира.",
                        longDesc="Дом находится на южной стороне",
                        phone="12345678900",
                        isFavourite=true,
                        Category = _categoryRealty.AllCategories.FirstOrDefault()
                    },
                    new Realty{ room="1-комнатная",
                        floor="17 этаж из 38",
                        squares="49м²",
                        metro="м.Гагарина",
                        adress="улица Ленинградская, дом 17, кв 350",
                        img="img/home2.webp",
                        price=2600000,
                        shortDesc="Очень хорошая квартира.",
                        longDesc="Дом находится на южной стороне",
                        phone="12345678900",
                        isFavourite=true,
                        Category = _categoryRealty.AllCategories.First()
                    },
                    new Realty{ room="3-комнатная",
                        floor="19 этаж из 24",
                        squares="140м²",
                        metro="м.Победа",
                        adress="улица Дальняя, дом 57, кв 192",
                        img="img/home3.jfif",
                        price=5600000,
                        shortDesc="Очень хорошая квартира.",
                        longDesc="Дом находится на южной стороне",
                        phone="12345678900",
                        isFavourite=true,
                        Category = _categoryRealty.AllCategories.First()
                    },
                     new Realty{ room="1-комнатная",
                        floor="30 этаж из 30",
                        squares="51м²",
                        metro="м.Спортивная",
                        adress="улица Московская шоссе, дом 10, кв 350",
                        img="img/home4.webp",
                        price=6600000,
                        shortDesc="Очень хорошая квартира.",
                        longDesc="Дом находится на южной стороне",
                        phone="12345678900",
                        isFavourite=true,
                        Category = _categoryRealty.AllCategories.First()
                     },
                      new Realty{ room="офис",
                        floor="77 этаж из 78",
                        squares="251м²",
                        metro="м.Московское",
                        adress="улица Московская шоссе, дом 10, офис 350",
                        img="img/office.jpg",
                        price=6600000,
                        shortDesc="Очень хороший офис.",
                        longDesc="Офис с хорошим ремонтом",
                        phone="12345678900",
                        isFavourite=true,
                        Category = _categoryRealty.AllCategories.First()
                      }
                };
            }
        }
        public IEnumerable<Realty> getFavRealty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Realty getObjectRealty(int realtyId)
        {
            throw new NotImplementedException();
        }
    }
}
