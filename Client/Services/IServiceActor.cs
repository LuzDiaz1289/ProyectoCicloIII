using ProyPeliculasHD.Shared.Entity;
using System.Collections.Generic;

namespace ProyPeliculasHD.Client.Services
{
    public interface IServiceActor
    {
        List<Actor> GetActors();
    }
}