using WebApplication5.ViewModels.Country;
using WebApplication5.ViewModels.Films;

namespace WebApplication5.Services.Interfaces
{
    public interface ICountryService
    {
        void Add(CountryAddEdit model);

        CountryAddEdit GetById(int id);
        void Update(CountryAddEdit model);
        
    }
}
