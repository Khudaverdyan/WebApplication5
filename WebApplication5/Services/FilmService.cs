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
            Film film = new Film()
            {
                Name = model.Name,
                DOC = model.DOC,
                AllowAge = model.AllowAge,
                Description = model.Description,
                Genre = model.Genre,
                Lenguage = model.Lenguage,
                Country = model.CountryId,
                DirectorId = model.DirectorId,  
                Quality = model.Quality,    
            };
            _filmsRepository.Add(film);
            _filmsRepository.SaveChanges();
        }

        public FilmsAddEdit GetById(int id)
        {
            var entityFilm  = _filmsRepository.GetById(id);
            return new FilmsAddEdit()
            { 
                Id = entityFilm.Id,
                Name = entityFilm.Name,
                Description =  entityFilm.Description,
                DOC = entityFilm.DOC,
                AllowAge = entityFilm.AllowAge,
                CountryId = entityFilm.Country,
            };  
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
    }

}
