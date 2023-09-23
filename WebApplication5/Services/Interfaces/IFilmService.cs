using WebApplication5.ViewModels.Films;

namespace WebApplication5.Services.Interfaces
{
    public interface IFilmService
    {
        void Add(FilmsAddEdit model);
        void Delete(int Id); 
        FilmsAddEdit GetById(int id);
        void Update(FilmsAddEdit film);
    
    }
}
