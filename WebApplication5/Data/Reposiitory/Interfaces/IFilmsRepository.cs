using WebApplication5.Data.Entity;
using WebApplication5.ViewModels.Films;

namespace WebApplication5.Data.Reposiitory.Interfaces
{
    public interface IFilmsRepository
    {
        void Add(Film film);
        Film GetById(int id);
        List<Film> GetAll();
        void Delete(Film film);
        void SaveChanges();
        void Add(FilmsAddEdit model);
    }
}
