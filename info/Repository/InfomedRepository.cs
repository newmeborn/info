
using info.Models;
using info.Repository.IRepository;

namespace info.Repository
{
    public class InfomedRepository : Repository<infomed>,  I_infomedRepository
    {
        private infoDbContext _context;
        
        public InfomedRepository(infoDbContext context) : base(context)
        {
        
            _context = context;
        }

        public void Update(infomed obj)
        {
            _context.Update(obj);
        }
    }
}
