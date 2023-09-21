using WebApplication5.ViewModels.Director;
using WebApplication5.ViewModels.Films;

namespace WebApplication5.Services.Interfaces
{
    public interface IDirectorService
    {
        void Add(DirectorAddEdit model);
        List<DirectorAddEditDropDown> GetListFromDown();
        DirectorAddEdit GetById(int id);
        void Update(DirectorAddEdit model);
        void SaveChanges();
    }
}

