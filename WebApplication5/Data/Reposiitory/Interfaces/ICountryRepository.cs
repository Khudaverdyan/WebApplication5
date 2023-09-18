using WebApplication5.Data.Entity;

namespace WebApplication5.Data.Reposiitory.Interfaces
{
    public interface ICountryRepository
    {
        void Add(Country country);
        Country GetById(int id);
        List<Country> GetAll();
        void Delete(Country country);
        void SaveChanges();
    }
}
