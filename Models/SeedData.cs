using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using movie2.Data;
using System;
using System.Linq;

namespace movie2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>()))
            {
                if (context.Movie.Any())
                    return;

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Velozes e Furiosos",
                        ReleaseDate = DateTime.Parse("2001-9-28"),
                        Genre = "Ação",
                        Price = 38M,
                        Rating = "A"
                    },
                    new Movie
                    {
                        Title = "Escola do Rock",
                        ReleaseDate = DateTime.Parse("2004-2-13"),
                        Genre = "Comédia",
                        Price = 35M,
                        Rating = "A"
                    },
                    new Movie
                    {
                        Title = "Senhor dos Anéis Retorno do Rei",
                        ReleaseDate = DateTime.Parse("2003-9-28"),
                        Genre = "Aventura",
                        Price = 95M,
                        Rating = "A"
                    },
                    new Movie
                    {
                        Title = "Star Wars: Episódio I – A Ameaça Fantasma",
                        ReleaseDate = DateTime.Parse("1999-6-24"),
                        Genre = "Aventura",
                        Price = 1.027M,
                        Rating = "B"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}