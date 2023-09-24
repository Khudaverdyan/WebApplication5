using WebApplication5.Data.Entity;
using WebApplication5.Data.Reposiitory.Interfaces;
using WebApplication5.Services.Interfaces;
using WebApplication5.ViewModels.Films;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApplication5.Services
{
    public class FilmService : IFilmService
    {
        private readonly IFilmsRepository _filmsRepository;
        public FilmService(IFilmsRepository filmsRepository)
        {
            _filmsRepository = filmsRepository;
        }
    
        public void Add(FilmsAddEdit model)
        {
            Film film = new Film();
            film.Id = model.Id;
            film.Name = model.Name;
            film.Description = model.Description;
            film.DOC = model.DOC;   
            film.Quality = model.Quality;
            film.AllowAge = model.AllowAge;
            film.DirectorId = model.DirectorId;
            var list = GetCountry();
            
           
            film.Lenguage = model.Lenguage;
            film.Genre = model.Genre;

            _filmsRepository.Add(film);
            _filmsRepository.SaveChanges();
        }

        public FilmsAddEdit GetById(int id)
        {
            var entityFilm  = _filmsRepository.GetById(id);
            var query = new FilmsAddEdit();
            query.Id = entityFilm.Id;
            query.Name = entityFilm.Name;
            query.Description = entityFilm.Description;
            query.DOC = entityFilm.DOC;
            query.Quality = entityFilm.Quality;
            query.AllowAge = entityFilm.AllowAge;
            query.DirectorId = entityFilm.DirectorId;
            var countryList =  GetCountry();
            query.Countries = countryList;
            query.Lenguage = entityFilm.Lenguage;
            query.Genre = entityFilm.Genre;
            return query;

        }

        public void Delete(int Id)
        {
            var entity =  _filmsRepository.GetById(Id);
            _filmsRepository.Delete(entity);
            _filmsRepository.SaveChanges();

        }

        public void Update(FilmsAddEdit model)
        {
            var entityFilm = _filmsRepository.GetById(model.Id);
           
            model.Id = entityFilm.Id;
            model.Name = entityFilm.Name;
            model.Description = entityFilm.Description;
            model.DOC = entityFilm.DOC;
            model.Quality = entityFilm.Quality;
            model.AllowAge = entityFilm.AllowAge;
            model.DirectorId = entityFilm.DirectorId;

            model.Lenguage = entityFilm.Lenguage;
            model.Genre = entityFilm.Genre;
            _filmsRepository.SaveChanges();
        }
        private List<Country> GetCountry()
        {
            Film film = new Film();
            return film.Countries.Select(p=> new Country()
            {
                Id = p.Id,
                Name = p.Name,
            }).ToList();
        }
    }

}
