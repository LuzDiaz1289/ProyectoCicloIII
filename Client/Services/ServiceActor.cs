using System;
using System.Collections.Generic;
using ProyPeliculasHD.Shared.Entity;

namespace ProyPeliculasHD.Client.Services
{
    public class ServiceActor:IServiceActor
    {
        public List<Actor> GetActors(){
            return  new  List < Actor > {
            new Actor(){Id=1,ActorName = "Brad Pitt", Gender = Gender.Masculino,Nationality="Estadounidense",BirthDate= new DateTime(1963,12,18),Photo="/Images/Actors/BPitt.jpg"},
            new Actor(){Id=2,ActorName = "Jim Carrey", Gender = Gender.Masculino,Nationality="Canadiense",BirthDate= new DateTime(1962,01,17),Photo="/Images/Actors/JCarrey.jpg"},
            new Actor(){Id=3,ActorName = "Robert Downey Jr.", Gender = Gender.Masculino,Nationality="Estadounidense",BirthDate= new DateTime(1965,04,04),Photo="/Images/Actors/RDowney.jpg"},
            new Actor(){Id=4,ActorName = "Sofia Carson", Gender = Gender.Femenino,Nationality="Estadounidense",BirthDate= new DateTime(1993,04,10),Photo="/Images/Actors/SCarson.jpg"},
            new Actor(){Id=5,ActorName = "Salma Hayek", Gender = Gender.Femenino,Nationality="Mexicana",BirthDate= new DateTime(1966,09,02),Photo="/Images/Actors/SHayek.jpg"},
            new Actor(){Id=6,ActorName = "Scarlett Johansson", Gender = Gender.Femenino,Nationality="Estadounidense",BirthDate= new DateTime(1984,11,22),Photo="/Images/Actors/SJohansson.jpg"}
            };
        }
    }
}