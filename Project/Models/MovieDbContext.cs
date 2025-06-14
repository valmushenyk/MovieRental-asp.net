using System.Data.Entity;

namespace Project.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext() : base("MovieRentalDB")
        {
            Database.SetInitializer(new MovieDbInitializer());
        }

        public DbSet<Movie> Movies { get; set; }
    }

    public class MovieDbInitializer : DropCreateDatabaseAlways<MovieDbContext>
    {
        protected override void Seed(MovieDbContext context)
        {
            var movies = new[]
            {
                new Movie
                {
                    Id = 1,
                    Title = "Skazani na Shawshank",
                    Description = "Dwóch więźniów nawiązuje przyjaźń na przestrzeni lat, znajdując pocieszenie i ostateczne odkupienie poprzez akty zwykłej przyzwoitości.",
                    RentalPrice = 4.99m,
                    IsAvailable = true,
                    ReleaseYear = 1994,
                    Genre = "Dramat",
                    Duration = 142
                },
                new Movie
                {
                    Id = 2,
                    Title = "Ojciec Chrzestny",
                    Description = "Starzejący się patriarcha zorganizowanej rodziny przestępczej przekazuje kontrolę swojemu niechętnemu synowi.",
                    RentalPrice = 5.99m,
                    IsAvailable = true,
                    ReleaseYear = 1972,
                    Genre = "Kryminał",
                    Duration = 175
                },
                new Movie
                {
                    Id = 3,
                    Title = "Mroczny Rycerz",
                    Description = "Gdy zagrożenie znane jako Joker sieje spustoszenie i chaos wśród mieszkańców Gotham, Batman musi stawić czoła jednemu z największych psychologicznych i fizycznych testów swojej zdolności do walki z niesprawiedliwością.",
                    RentalPrice = 6.99m,
                    IsAvailable = false,
                    ReleaseYear = 2008,
                    Genre = "Akcja",
                    Duration = 152
                },
                new Movie
                {
                    Id = 4,
                    Title = "Pulp Fiction",
                    Description = "Życia dwóch płatnych zabójców, boksera, gangstera i jego żony oraz pary bandytów z restauracji splatają się w czterech opowieściach o przemocy i odkupieniu.",
                    RentalPrice = 5.49m,
                    IsAvailable = true,
                    ReleaseYear = 1994,
                    Genre = "Kryminał",
                    Duration = 154
                },
                new Movie
                {
                    Id = 5,
                    Title = "Forrest Gump",
                    Description = "Prezydentury Kennedy'ego i Johnsona, wojna w Wietnamie, afera Watergate i inne wydarzenia historyczne ukazane z perspektywy mieszkańca Alabamy o IQ 75.",
                    RentalPrice = 4.99m,
                    IsAvailable = true,
                    ReleaseYear = 1994,
                    Genre = "Dramat",
                    Duration = 142
                }
            };

            context.Movies.AddRange(movies);
            context.SaveChanges();

            base.Seed(context);
        }
    }
} 