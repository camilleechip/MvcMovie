using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG-13",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG-13",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "N/A",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Hoppers",
                    ReleaseDate = DateTime.Parse("2026-03-06"),
                    Genre = "Family",
                    Rating = "PG",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Coco",
                    ReleaseDate = DateTime.Parse("2017-11-22"),
                    Genre = "Family",
                    Rating = "PG",
                    Price = 5.99M
                },
                new Movie
                {
                    Title = "Puss in Boots: Last Wish",
                    ReleaseDate = DateTime.Parse("2020-12-21"),
                    Genre = "Family",
                    Rating = "PG",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Good Dinosaur",
                    ReleaseDate = DateTime.Parse("2015-11-25"),
                    Genre = "Family",
                    Rating = "PG",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}