using WebApplication5.Data.Entity;
using WebApplication5.Data.Reposiitory.Interfaces;
using WebApplication5.Services.Interfaces;
using WebApplication5.ViewModels.Films;

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
            var list = GetCountryId();
            list = model.CountryId;
            
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
            var list = GetCountryId();
            list = query.CountryId;


        }

        

        public List<FilmsAddEditDropDown> GetListFromDown()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(FilmsAddEdit model)
        {
            throw new NotImplementedException();
        }
        private List<int> GetCountryId()
        {
            Film film = new Film();
             return film.Countries.Select(p => p.Id).ToList();
        }
    }

}
