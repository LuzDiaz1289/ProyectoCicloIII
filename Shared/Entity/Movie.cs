using System;
/* using System.ComponentModel.DataAnnotations; */
namespace ProyPeliculasHD.Shared.Entity
{
    public class Movie
    {
        /* public int Id {get;set;}
        [Required] */
        public string  NameMovie{get;set;}
        public string Synopsis {get;set;}
        public string ImageMovie {get;set;}
        public DateTime ReleaseDate {get;set;}
    }
}