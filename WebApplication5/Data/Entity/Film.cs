using Microsoft.AspNetCore.Mvc.Razor;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication5.Enum;
namespace WebApplication5.Data.Entity
{
    public class Film
    {
        public int Id { get; set; }     
        public string Name { get; set; }
        public DateTime DOC { get;set; }    
        public string AllowAge { get; set; }  
        public string Description { get; set; }     

        public ICollection<Country> Countries { get;set;}
             
        public GenreEnum Genre { get; set; }
        [ForeignKey("Directors")]   
        
        public  int DirectorId   { get; set; }      
        public Director Directors { get; set; }  
        public LenguageEnum Lenguage { get; set; }      
        public QualityEnum Quality { get; set; }    

    }
}
