using WebApplication5.ViewModels.Films;

namespace WebApplication5.Services.Interfaces
{
    public interface IFilmService
    {
        void Add(FilmsAddEdit model);
        List<FilmsAddEditDropDown> GetListFromDown();
        FilmsAddEdit GetById(int id);
        void Update(FilmsAddEdit model);
        void SaveChanges();
    }
}
