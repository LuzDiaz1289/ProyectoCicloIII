using System;
using System.ComponentModel.DataAnnotations;
namespace ProyPeliculasHD.Shared.Entity
{
    public class Actor
    {
        public int Id {get;set;}
        [Required]
        public string ActorName{get;set;}
        public string Nationality {get;set;}
        public Gender Gender {get;set;}
         [Required]
        public DateTime BirthDate{get;set;}
        public string Photo {get;set;}
    }

    public enum Gender{
        Femenino = 0,
        Masculino = 1
    }
}