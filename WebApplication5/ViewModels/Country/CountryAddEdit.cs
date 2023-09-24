using WebApplication5.Data.Entity;

namespace WebApplication5.ViewModels.Country
{
    public class CountryAddEdit
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public List<CountryAddEditDropDown> CountriesFilm { get; set; }
    }
}
