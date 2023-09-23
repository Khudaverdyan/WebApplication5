using WebApplication5.Data.Reposiitory.Interfaces;
using WebApplication5.Services.Interfaces;
using WebApplication5.ViewModels.Country;

namespace WebApplication5.Services
{
    public class CountryService:ICountryService
    {
        private readonly ICountryService _countryService;
        public CountryService(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public void Add(CountryAddEdit model)
        {
            throw new NotImplementedException();
        }

        public CountryAddEdit GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CountryAddEditDropDown> GetDropDownList()
        {
            throw new NotImplementedException();
        }

        public void Update(CountryAddEdit model)
        {
            throw new NotImplementedException();
        }
    }
}
