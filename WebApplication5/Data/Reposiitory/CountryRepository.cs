using WebApplication5.Data.Entity;
using WebApplication5.Data.Reposiitory.Interfaces;

namespace WebApplication5.Data.Reposiitory
{
    public class CountryRepository : ICountryRepository
    {

        private readonly MyContext _context;
        public CountryRepository(MyContext context)
        {
            _context = context;
        }
        public void Add(Country country)
        {
            _context.Add(country);
            _context.SaveChanges();
        }

        public void Delete(Country country)
        {
            _context.Remove(country);
            _context.SaveChanges();
        }

        public List<Country> GetAll()
        {
            return _context.Countries.ToList();
        }

        public Country GetById(int id)
        {
            return _context.Countries.Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
