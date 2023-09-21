using WebApplication5.Data.Entity;
using WebApplication5.Data.Reposiitory.Interfaces;
using WebApplication5.ViewModels.Films;

namespace WebApplication5.Data.Reposiitory
{
    public class FilmsRepository : IFilmsRepository
    {
        private readonly MyContext _context;
        public FilmsRepository(MyContext context)
        {
            _context = context;   
        }
        public void Add(Film film)
        {
            _context.Add(film);
            _context.SaveChanges();
        }

        public void Add(FilmsAddEdit model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Film film)
        {
            _context.Remove(film);
            _context.SaveChanges();
        }

        public List<Film> GetAll()
        {
          return  _context.Films.ToList();
        }

        public Film GetById(int id)
        {
            return _context.Films.Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
