namespace MusicQuiz.Migrations
{
    using MovieQuiz.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieQuiz.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieQuiz.Models.ApplicationDbContext context)
        {
            var questions = new List<TriviaQuestion>();

            questions.Add(new TriviaQuestion
            {
                Title = "Który z filmów Quentina Tarantino nosi miano jego pierwszego ?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Jackie Brown", IsCorrect = false },
                    new TriviaOption { Title = "Kill Bill Vol. 1", IsCorrect = false },
                    new TriviaOption { Title = "Pulp Fiction", IsCorrect = false },
                    new TriviaOption { Title = "Wściekłe Psy", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Kto odgrywa tytułową rolę w filmie 'Django'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Denzel Washington", IsCorrect = false },
                    new TriviaOption { Title = "Samuel L. Jackson", IsCorrect = false },
                    new TriviaOption { Title = "Morgan Freeman", IsCorrect = false },
                    new TriviaOption { Title = "Jamie Foxx", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Która aktorka zagrała główną rolę w 'Nienawistnej Ósemce?'",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Diane Keaton", IsCorrect = false },
                    new TriviaOption { Title = "Gwyneth Paltrow", IsCorrect = false },
                    new TriviaOption { Title = "Jennifer Jason Leigh", IsCorrect = true },
                    new TriviaOption { Title = "Uma Thurman", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Który z aktorów zagrał główną rolę w 'Jestem legendą'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Henry Cavill", IsCorrect = false },
                    new TriviaOption { Title = "Russel Crowe", IsCorrect = false },
                    new TriviaOption { Title = "Will Smith", IsCorrect = true },
                    new TriviaOption { Title = "Jamie Foxx", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Kto wyreżyserował film 'Ready Player One'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Steven Spielberg", IsCorrect = true },
                    new TriviaOption { Title = "Peter Jackson", IsCorrect = false },
                    new TriviaOption { Title = "James Cameron", IsCorrect = false },
                    new TriviaOption { Title = "Michael Bay", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Który film zdobył Oscara za Najlepszy Film w 2015 roku?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Moonlight", IsCorrect = false },
                    new TriviaOption { Title = "Green Book", IsCorrect = false },
                    new TriviaOption { Title = "Birdman", IsCorrect = true },
                    new TriviaOption { Title = "Spotlight", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Kto zagrał główną rolę w filmie 'Drive' z 2011 roku?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Hugh Jackman", IsCorrect = false },
                    new TriviaOption { Title = "Ryan Reynolds", IsCorrect = false },
                    new TriviaOption { Title = "Ryan Gosling", IsCorrect = true },
                    new TriviaOption { Title = "Owen Wilson", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Kto wyreżyserował 'Blade Runner 2049'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "J.J. Abrams", IsCorrect = false },
                    new TriviaOption { Title = "Dennis Villeneuve", IsCorrect = true },
                    new TriviaOption { Title = "Peter Jackson", IsCorrect = false },
                    new TriviaOption { Title = "Patrick Hughes", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Jak nazywa się aktor grający aktualnie Bonda?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Daniel Craig", IsCorrect = true },
                    new TriviaOption { Title = "Henry Cavil", IsCorrect = false },
                    new TriviaOption { Title = "Tom Hardy", IsCorrect = false },
                    new TriviaOption { Title = "Hugh Grant", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Która z aktorek nie wcieliła się w rolę Kobiety-Kot?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Scarlett Johansson", IsCorrect = true },
                    new TriviaOption { Title = "Halle Berry", IsCorrect = false },
                    new TriviaOption { Title = "Michelle Pfeiffer", IsCorrect = false },
                    new TriviaOption { Title = "Anne Hathaway", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Kto zagrał główną rolę w 'Locie nad kukułczym gniazdem'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Jack Nicholson", IsCorrect = true },
                    new TriviaOption { Title = "Robert De Niro", IsCorrect = false },
                    new TriviaOption { Title = "Joe Pesci", IsCorrect = false },
                    new TriviaOption { Title = "Ray Liotta", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Kto wyreżyserował 'Chłopców z ferajny'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Quentin Tarantino", IsCorrect = false },
                    new TriviaOption { Title = "Brian De Palma", IsCorrect = false },
                    new TriviaOption { Title = "Clint Eastwood", IsCorrect = false },
                    new TriviaOption { Title = "Martin Scorsese", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Kto wyreżyserował 'Czarną Dalię'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Ryan Coogler", IsCorrect = false },
                    new TriviaOption { Title = "Jordan Peele", IsCorrect = false },
                    new TriviaOption { Title = "Brian De Palma", IsCorrect = true },
                    new TriviaOption { Title = "Abe Forsythe", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Z którego roku jest 'Lista Schindlera'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "1994", IsCorrect = false },
                    new TriviaOption { Title = "1992", IsCorrect = false },
                    new TriviaOption { Title = "1993", IsCorrect = true },
                    new TriviaOption { Title = "1991", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Z którego roku jest 'Pianista'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "2002", IsCorrect = true },
                    new TriviaOption { Title = "2001", IsCorrect = false },
                    new TriviaOption { Title = "2000", IsCorrect = false },
                    new TriviaOption { Title = "1999", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Która z aktorek zagrała w 'Milczeniu owiec'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Scarlett Johansson", IsCorrect = false },
                    new TriviaOption { Title = "Julianne Moore", IsCorrect = false },
                    new TriviaOption { Title = "Rachel McAdams", IsCorrect = false },
                    new TriviaOption { Title = "Jodie Foster", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Ben Affleck nie zagrał w...",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Zaginiona dziewczyna", IsCorrect = false },
                    new TriviaOption { Title = "Avengers", IsCorrect = true },
                    new TriviaOption { Title = "Nocne życie", IsCorrect = false },
                    new TriviaOption { Title = "Stan gry", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Która z aktorek zagrała główną rolę w 'Nagim instynkcie'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Sharon Stone", IsCorrect = true },
                    new TriviaOption { Title = "Demi Moore", IsCorrect = false },
                    new TriviaOption { Title = "Jacki Weaver", IsCorrect = false },
                    new TriviaOption { Title = "Kristen Stewart", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Josh Hartnett nie zagrał w...",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Pearl Harbor", IsCorrect = false },
                    new TriviaOption { Title = "30 dni mroku", IsCorrect = false },
                    new TriviaOption { Title = "Helikopter w ogniu", IsCorrect = false },
                    new TriviaOption { Title = "Operacja Argo", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Jeremy Renner nie zagrał w...",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Nowy początek", IsCorrect = false },
                    new TriviaOption { Title = "Dziedzictwo Bourne'a", IsCorrect = false },
                    new TriviaOption { Title = "Hurt Locker", IsCorrect = false },
                    new TriviaOption { Title = "Godzilla", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Kto zagrał główną rolę w 'Godzilli' z 2014 roku?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Brad Pitt", IsCorrect = false },
                    new TriviaOption { Title = "Eli Roth", IsCorrect = false },
                    new TriviaOption { Title = "Christoph Waltz", IsCorrect = false },
                    new TriviaOption { Title = "Aaron Taylor-Johnson", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Kto nie zagrał w 'Mieście złodziei'?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Rebecca Hall", IsCorrect = false },
                    new TriviaOption { Title = "Demi Moore", IsCorrect = true },
                    new TriviaOption { Title = "Ben Affleck", IsCorrect = false },
                    new TriviaOption { Title = "Jon Hamm", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Jake Gyllenhaal nie zagrał w... ?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "Pojutrze", IsCorrect = false },
                        new TriviaOption { Title = "Spotlight", IsCorrect = true },
                        new TriviaOption { Title = "Labirynt", IsCorrect = false },
                        new TriviaOption { Title = "Zodiak", IsCorrect = false }
                    }).ToList()
            });

            questions.ForEach(a => context.TriviaQuestions.Add(a));

            context.SaveChanges();
        }
    }
}
