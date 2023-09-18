using WebApplication5.Data.Entity;
using WebApplication5.Data.Reposiitory.Interfaces;

namespace WebApplication5.Data.Reposiitory
{
    public class DirectorRepository : IDirectorRepository
    {

        private readonly MyContext _context;
        public DirectorRepository(MyContext context)
        {
            _context = context;
        }
        public void Add(Director director)
        {
            _context.Add(director);
            _context.SaveChanges();
        }

        public void Delete(Director director)
        {
            _context.Remove(director);
            _context.SaveChanges();
        }

        public List<Director> GetAll()
        {
            return _context.Directors.ToList();
        }

        public Director GetById(int id)
        {
            return _context.Directors.Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
