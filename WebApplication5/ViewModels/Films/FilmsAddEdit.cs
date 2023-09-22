using WebApplication5.Enum;                                                                                                                       sing WebApplication5.Enum;

namespace WebApplication5.ViewModels.Films
{
    public class FilmsAddEdit
    {
        public int Id { get; set; }     
        public string Name { get; set; }        
        public string Description { get; set; }
        public DateTime DOC { get; set; }   
        public string AllowAge { get; set; }  
        public int CountryId { get;set; }

        public int DirectorId { get; set; }
        public LenguageEnum Lenguage { get; set; }
        public GenreEnum Genre { get; set; }  
        public QualityEnum Quality { get; set; }    

    }
}
