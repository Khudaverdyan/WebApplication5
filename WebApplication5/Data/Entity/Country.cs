﻿namespace WebApplication5.Data.Entity
{
    public class Country
    {
        public int Id { get; set; }     
        public string Name { get; set; }  
        public ICollection<Country> Countries { get; set;}
    }
}
