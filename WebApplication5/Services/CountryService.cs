using WebApplication5.Data.Entity;
using WebApplication5.Data.Reposiitory.Interfaces;
using WebApplication5.Services.Interfaces;
using WebApplication5.ViewModels.Country;
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
            _countryRepository.Add(country);
            _countryRepository.SaveChanges();
        }

        public CountryAddEdit GetById(int id)
        {
            var entityEntity = _countryRepository.GetById(id);
            CountryAddEdit query = new CountryAddEdit(); 
            query.Id = entityEntity.Id;  
            query.Name = entityEntity.Name; 
            return query;
        }

        public void Update(CountryAddEdit model)
        {
            var entityCountry = _countryRepository.GetById(model.Id);
            entityCountry.Id = model.Id;
            entityCountry.Name = model.Name;            
        }
      

    }
}
