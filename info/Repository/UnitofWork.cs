using info.Models;
using info.Repository.IRepository;

namespace info.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private infoDbContext _context;

        public UnitofWork(infoDbContext context)
        {

            _context = context;
            Infomed = new InfomedRepository(_context);
        }

        public I_infomedRepository Infomed { get; private set; }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
