using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "hello",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "hello",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "hello",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "hello",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "hello",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "hello",
                        Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
