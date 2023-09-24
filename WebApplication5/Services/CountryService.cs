using WebApplication5.Data.Reposiitory.Interfaces;
using WebApplication5.Services.Interfaces;
using WebApplication5.ViewModels.Country;
using WebApplication5.Data.Entity;
namespace WebApplication5.Services
{
    public class CountryService:ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public void Add(CountryAddEdit model)
        {
            Country  country = new Country();
            country.Id = model.Id;  
            country.Name = model.Name;
            counrty.Country = model.CountriesFilm;
            _countryRepository.Add(country);
            _countryRepository.SaveChanges();

        }

        public CountryAddEdit GetById(int id)
        {
            Country entityEntity = _countryRepository.GetById(id);
            CountryAddEdit query = new CountryAddEdit(); 
            query.Id = entityEntity.Id;
           
            return query;
        }

        public List<CountryAddEditDropDown> GetDropDownList()
        {
            var data = _countryRepository.GetAll();
            var data1 = data.Select(f => new CountryAddEditDropDown
            {
                Id = f.Id,
                Name = f.Name,
            }).ToList();
            return data1;
             
        }

        public void Update(CountryAddEdit model)
        {
            var entityCountry = _countryRepository.GetById(model.Id);
            entityCountry.Id = model.Id;
            entityCountry.Name = model.Name;
            

        }
        private List<CountryAddEditDropDown> GetFilmsCountry( )
        {
            Country country = new Country();
            return country.CountriesFilms.Select(c => new Country
            {
                Id = c.Id,  
                Name = c.Name,  
            }).ToList();          
        }

    }
}
