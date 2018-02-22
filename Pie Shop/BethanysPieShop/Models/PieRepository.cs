using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        IEnumerable<Pie> IPieRepository.GetAllPies()
        {
            return _appDbContext.Pies;
        }

        Pie IPieRepository.GetPieById(int pieID)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.Id == pieID);
        }
    }
}
