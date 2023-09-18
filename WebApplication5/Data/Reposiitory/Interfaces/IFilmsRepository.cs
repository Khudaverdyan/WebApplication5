using WebApplication5.Data.Entity;
namespace WebApplication5.Data.Reposiitory.Interfaces
{
    public interface IFilmsRepository
    {
        void Add(Film film);
        Film GetById(int id);
        List<Film> GetAll();
        void Delete(Film film);
        void SaveChanges();

    }
}
