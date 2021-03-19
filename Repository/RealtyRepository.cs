using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA20.interfaces;
using WA20.Models;

namespace WA20.Repository
{
    public class RealtyRepository : IAllRealty
    {
        private readonly AppDBContent appDBContent;
        public RealtyRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Realty> Realty => appDBContent.Realty.Include(c => c.Category);

        public IEnumerable<Realty> getFavRealty => appDBContent.Realty.Where(p => p.isFavourite).Include(c => c.Category);

        public Realty getObjectRealty(int realtyId) => appDBContent.Realty.FirstOrDefault(p => p.id == realtyId);

    }
}
