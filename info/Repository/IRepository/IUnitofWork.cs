namespace info.Repository.IRepository
{
    public interface IUnitofWork
    {
        I_infomedRepository Infomed{ get; }

        void Save();
       
    }
}
