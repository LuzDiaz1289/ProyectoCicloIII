using System;
using ProyPeliculasHD.Shared.Entity;
using System.Collections.Generic;

namespace ProyPeliculasHD.Client.Services
{
    public class ServiceMovie:IServiceMovie
    {
        public List<Movie> GetMovies(){
            return new List<Movie>{
                new Movie(){NameMovie="Aladin",Synopsis="Aladdin es un ingenioso joven que vive en una extrema pobreza, y que sueña con casarse con la bella hija del sultán, la princesa Yasmine. El destino interviene cuando el astuto visir del Sultán, Yafar, recluta a Aladdin para que le ayude a recuperar una lámpara mágica de las profundidades de la Cueva de las Maravillas. Aladdin encuentra una lámpara maravillosa con un genio dentro, y sus deseos comienzan a hacerse realidad.",ImageMovie="/Images/Movies/Aladin.jpg",ReleaseDate=new DateTime(1991,09,20)},
                new Movie(){NameMovie="Alicia en el país de la maravillas",Synopsis="Alicia viaja al fantástico mundo de las maravillas, un universo lleno de magia y fantasía, donde conocerá a extraordinarios personajes, como un conejo blanco, un gato sonriente, a Sombrerero Loco y a la Reina de Corazones, que continuamente manda a cortar cabezas.",ImageMovie="/Images/Movies/Alicia.jpg",ReleaseDate=new DateTime(1951,09,20)},
                new Movie(){NameMovie="Blancanieves y los 7 enanitos",Synopsis="La malvada madrastra de Blancanieves no puede soportar que la belleza de la joven sea superior a la suya y decide acabar con su vida. La bellísima Blancanieves consigue refugiarse en una minúscula cabaña del bosque en la que habitan siete simpáticos enanitos. A pesar de todo, la cruel madrastra consigue dar con su paradero y la envenena con una manzana. El veneno sumirá a la joven en un sueño eterno del que tan sólo un príncipe azul podrá despertarla.",ImageMovie="/Images/Movies/Blancanieves.jpg", ReleaseDate=new DateTime(1937,09,20)},
                new Movie(){NameMovie="Cenicienta",Synopsis="Cuenta las andanzas de la joven Ella cuyo padre, un comerciante, vuelve a casarse tras la muerte de su madre. Pero, cuando el padre de Ella muere inesperadamente, la joven se encuentra a merced de una nueva familia celosa y cruel.",ImageMovie="/Images/Movies/Cenicienta.jpg", ReleaseDate=new DateTime(1950,09,20)},
                new Movie(){NameMovie="La bella y la bestia",Synopsis="Un apuesto y arrogante príncipe es víctima de una maldición por parte de una hechicera a quien niega hospitalidad: vivirá en el cuerpo de una horrible bestia hasta que sea capaz de despertar en una joven el amor verdadero. Los años pasan y la bestia no consigue romper el hechizo.",ImageMovie="/Images/Movies/LaBellayBestia.jpg",ReleaseDate=new DateTime(1991,09,20)},
                new Movie(){NameMovie="Pocahontas",Synopsis="Pocahontas es una joven india muy aventurera y decidida, a la que le encanta la naturaleza y ser un espíritu libre para poder conocer todo lo que la rodea, pero a pesar de lo que ella querría, tiene que cumplir unas ciertas normas, ya que es la hija del jefe de una tribu, el Jefe Powhatan.",ImageMovie="/Images/Movies/Pocahontas.jpg",ReleaseDate=new DateTime(1995,09,20)}
            };
        }
    }
}