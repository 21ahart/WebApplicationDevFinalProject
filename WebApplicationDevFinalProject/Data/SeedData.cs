using WebApplicationDevFinalProject.Models;

namespace WebApplicationDevFinalProject.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            var seedMovies = new List<Movie>
            {
                new() { Title = "The Shawshank Redemption", Genre = "Drama", ReleaseYear = 1994, Rating = 9.3m, Description = "A story of hope and friendship inside prison." },
                new() { Title = "The Godfather", Genre = "Crime", ReleaseYear = 1972, Rating = 9.2m, Description = "A classic saga of family and power." },
                new() { Title = "The Dark Knight", Genre = "Action", ReleaseYear = 2008, Rating = 9.0m, Description = "Batman faces chaos in Gotham." },
                new() { Title = "Pulp Fiction", Genre = "Crime", ReleaseYear = 1994, Rating = 8.9m, Description = "Interwoven stories of crime in LA." },
                new() { Title = "Forrest Gump", Genre = "Drama", ReleaseYear = 1994, Rating = 8.8m, Description = "An extraordinary life through historic moments." },
                new() { Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010, Rating = 8.8m, Description = "A heist that takes place within dreams." },
                new() { Title = "Fight Club", Genre = "Drama", ReleaseYear = 1999, Rating = 8.8m, Description = "A dark exploration of identity and consumerism." },
                new() { Title = "The Matrix", Genre = "Sci-Fi", ReleaseYear = 1999, Rating = 8.7m, Description = "Reality is not what it seems." },
                new() { Title = "Interstellar", Genre = "Sci-Fi", ReleaseYear = 2014, Rating = 8.7m, Description = "A journey through space and time." },
                new() { Title = "Goodfellas", Genre = "Crime", ReleaseYear = 1990, Rating = 8.7m, Description = "The rise and fall of a mob associate." },

                new() { Title = "Se7en", Genre = "Thriller", ReleaseYear = 1995, Rating = 8.6m, Description = "Detectives hunt a serial killer with deadly themes." },
                new() { Title = "The Silence of the Lambs", Genre = "Thriller", ReleaseYear = 1991, Rating = 8.6m, Description = "An FBI trainee seeks help from Hannibal Lecter." },
                new() { Title = "Saving Private Ryan", Genre = "War", ReleaseYear = 1998, Rating = 8.6m, Description = "A rescue mission during WWII." },
                new() { Title = "The Green Mile", Genre = "Drama", ReleaseYear = 1999, Rating = 8.6m, Description = "Miracles and justice on death row." },
                new() { Title = "Parasite", Genre = "Thriller", ReleaseYear = 2019, Rating = 8.5m, Description = "Class conflict with shocking twists." },
                new() { Title = "Gladiator", Genre = "Action", ReleaseYear = 2000, Rating = 8.5m, Description = "A general seeks vengeance in the arena." },
                new() { Title = "Whiplash", Genre = "Drama", ReleaseYear = 2014, Rating = 8.5m, Description = "A drummer pushed to his limits." },
                new() { Title = "The Departed", Genre = "Crime", ReleaseYear = 2006, Rating = 8.5m, Description = "An undercover war between cops and mob." },
                new() { Title = "The Prestige", Genre = "Mystery", ReleaseYear = 2006, Rating = 8.5m, Description = "Two rival magicians in a dangerous obsession." },
                new() { Title = "The Lion King", Genre = "Animation", ReleaseYear = 1994, Rating = 8.5m, Description = "A prince reclaims his kingdom." },

                new() { Title = "The Pianist", Genre = "Biography", ReleaseYear = 2002, Rating = 8.5m, Description = "A musician survives wartime occupation." },
                new() { Title = "Joker", Genre = "Drama", ReleaseYear = 2019, Rating = 8.4m, Description = "A man descends into madness." },
                new() { Title = "Alien", Genre = "Horror", ReleaseYear = 1979, Rating = 8.4m, Description = "A crew faces a terrifying creature in space." },
                new() { Title = "The Shining", Genre = "Horror", ReleaseYear = 1980, Rating = 8.4m, Description = "Isolation and terror at a remote hotel." },
                new() { Title = "Django Unchained", Genre = "Western", ReleaseYear = 2012, Rating = 8.4m, Description = "A bounty hunter and a freed man seek justice." },
                new() { Title = "WALL-E", Genre = "Animation", ReleaseYear = 2008, Rating = 8.4m, Description = "A lonely robot changes humanity's future." },
                new() { Title = "Toy Story", Genre = "Animation", ReleaseYear = 1995, Rating = 8.3m, Description = "Toys come to life when humans are away." },
                new() { Title = "Up", Genre = "Animation", ReleaseYear = 2009, Rating = 8.3m, Description = "An adventure tied to a lifelong promise." },
                new() { Title = "Avengers: Endgame", Genre = "Action", ReleaseYear = 2019, Rating = 8.4m, Description = "Heroes unite for one final battle." },
                new() { Title = "The Avengers", Genre = "Action", ReleaseYear = 2012, Rating = 8.0m, Description = "Earth's mightiest heroes assemble." },

                new() { Title = "Iron Man", Genre = "Action", ReleaseYear = 2008, Rating = 7.9m, Description = "A genius builds a suit to become a hero." },
                new() { Title = "Black Panther", Genre = "Action", ReleaseYear = 2018, Rating = 7.3m, Description = "A king protects Wakanda and its future." },
                new() { Title = "Doctor Strange", Genre = "Fantasy", ReleaseYear = 2016, Rating = 7.5m, Description = "A surgeon discovers mystical powers." },
                new() { Title = "Spider-Man: No Way Home", Genre = "Action", ReleaseYear = 2021, Rating = 8.2m, Description = "A multiverse crisis changes everything." },
                new() { Title = "Mad Max: Fury Road", Genre = "Action", ReleaseYear = 2015, Rating = 8.1m, Description = "A high-octane survival chase." },
                new() { Title = "Blade Runner 2049", Genre = "Sci-Fi", ReleaseYear = 2017, Rating = 8.0m, Description = "A replicant mystery in a dystopian future." },
                new() { Title = "Arrival", Genre = "Sci-Fi", ReleaseYear = 2016, Rating = 7.9m, Description = "A linguist communicates with aliens." },
                new() { Title = "The Social Network", Genre = "Drama", ReleaseYear = 2010, Rating = 7.8m, Description = "The story behind a tech empire." },
                new() { Title = "La La Land", Genre = "Romance", ReleaseYear = 2016, Rating = 8.0m, Description = "Love and ambition in Los Angeles." },
                new() { Title = "The Grand Budapest Hotel", Genre = "Comedy", ReleaseYear = 2014, Rating = 8.1m, Description = "A whimsical tale of a legendary concierge." },

                new() { Title = "The Wolf of Wall Street", Genre = "Biography", ReleaseYear = 2013, Rating = 8.2m, Description = "A reckless rise in the finance world." },
                new() { Title = "No Country for Old Men", Genre = "Thriller", ReleaseYear = 2007, Rating = 8.2m, Description = "Violence and fate collide in Texas." },
                new() { Title = "Prisoners", Genre = "Thriller", ReleaseYear = 2013, Rating = 8.1m, Description = "A desperate search for missing children." },
                new() { Title = "Nightcrawler", Genre = "Thriller", ReleaseYear = 2014, Rating = 7.8m, Description = "A cameraman chases crime footage at any cost." },
                new() { Title = "Memento", Genre = "Mystery", ReleaseYear = 2000, Rating = 8.4m, Description = "A man with memory loss seeks revenge." },
                new() { Title = "Shutter Island", Genre = "Mystery", ReleaseYear = 2010, Rating = 8.2m, Description = "A marshal investigates a psychiatric facility." },
                new() { Title = "The Truman Show", Genre = "Drama", ReleaseYear = 1998, Rating = 8.2m, Description = "A man discovers his life is a TV show." },
                new() { Title = "The Imitation Game", Genre = "Biography", ReleaseYear = 2014, Rating = 8.0m, Description = "Cracking Enigma during WWII." },
                new() { Title = "1917", Genre = "War", ReleaseYear = 2019, Rating = 8.2m, Description = "Two soldiers race to deliver a critical message." },
                new() { Title = "Dune", Genre = "Sci-Fi", ReleaseYear = 2021, Rating = 8.0m, Description = "A young noble rises amid interstellar conflict." }
            };

            var existingTitles = context.Movies
                .Select(m => m.Title)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            var moviesToAdd = seedMovies
                .Where(m => !existingTitles.Contains(m.Title))
                .ToList();

            if (moviesToAdd.Count == 0)
            {
                return;
            }

            context.Movies.AddRange(moviesToAdd);
            context.SaveChanges();
        }
    }
}
