using WebApplication5.Data.Entity;

namespace WebApplication5.Data.Reposiitory.Interfaces
{
    public interface IDirectorRepository
    {
        void Add(Director director);
        Director GetById(int id);
        List<Director> GetAll();
        void Delete(Director director);
        void SaveChanges();
    }
}
