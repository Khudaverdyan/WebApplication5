using System.ComponentModel.Design;
using WebApplication5.Data.Reposiitory.Interfaces;
using WebApplication5.Data.Entity;
using WebApplication5.Services.Interfaces;
using WebApplication5.ViewModels.Director;

namespace WebApplication5.Services
{
    public class DirectorService:IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;
        public DirectorService(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        public void Add(DirectorAddEdit model)
        {
            Director director = new Director();
            director.Id = model.Id;
            director.Name = model.Name;
            var list = GetFilmsId();
            list = model.DirectorsFilmsId;
            _directorRepository.Add(director);
            _directorRepository.SaveChanges();
        }

        public DirectorAddEdit GetById(int id)
        {
            Director entity = _directorRepository.GetById(id);
            DirectorAddEdit query = new DirectorAddEdit();
            query.Id = entity.Id;   
            query.Name = entity.Name;
            query.DirectorsFilmsId = GetFilmsId();
            return query;

        }

        public void Update(int id)
        {
            Director entityDirector = _directorRepository.GetById(id);
            DirectorAddEdit query = new DirectorAddEdit();
            query.Id = entityDirector.Id;
            query.Name = entityDirector.Name;
            query.DirectorsFilmsId = GetFilmsId();

        }
        private List<int> GetFilmsId()
        {
            Director director = new Director();
            var list = director.DirectorsFilms.Select(p => p.Id).ToList();
            return list;
        }
    }
}
