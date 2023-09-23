namespace WebApplication5.ViewModels.Director
{
    public class DirectorAddEdit
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public List<int> DirectorsFilmsId { get; set; }
    }
}
