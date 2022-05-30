using info.Models;

namespace info.Repository.IRepository
{
    public interface I_infomedRepository : IRepository<infomed>
    // so with that our infomed repository will get all the methods that are implemented inside the genetic repository
    {
        void Update(infomed obj);
       
    }
}
