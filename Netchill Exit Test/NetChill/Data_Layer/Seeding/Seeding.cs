using NetChill.DAL;
using System;
using System.Data.Entity;

namespace Data_Layer.Seeding
{
    //Seeding
    public class Seeding: DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            context.Users.Add(new User()
            {
                FullName="Admin",
                Email="admin@netchill.com",
                Password="Admin@123",
                IsAdmin=true,
                isRevoked=false,
            });

            context.Movies.Add(new Movie()
            {
                Name = "Black Panther",
                Category = "Action",
                YearOfRelease = 2019,
                AvailaibilityStarts = new DateTime(2001 - 12 - 22 ),
                Description = "Black Panther is a 2018 American superhero film based on the Marvel Comics character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 18th film in the Marvel Cinematic Universe (MCU)",
                IsFeatured=true,
                ContentPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fmovies%2F1671599816782?alt=media&token=1a002744-0c32-4c3d-a44e-014d58ae2fec",
                Views = 1,
                PosterPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fimages%2F1671599810590?alt=media&token=75c7d2c8-f957-4745-8e9f-155071d84926",

            });
            context.Movies.Add(new Movie()
            {
                Name = "Iron Man",
                Category = "Action",
                YearOfRelease = 2008,
                AvailaibilityStarts = new DateTime(2009 - 11 - 12),
                Description = "Iron Man is a superhero appearing in American comic books published by Marvel Comics. The character was co-created by writer and editor Stan Lee, developed by scripter Larry Lieber, and designed by artists Don Heck and Jack Kirby. The character made his first appearance in Tales of Suspense ",
                IsFeatured = true,
                ContentPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fmovies%2F1671601890926?alt=media&token=7e8b1cf0-8f78-40d0-8542-20ea88dbe012",
                Views = 1,
                PosterPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fimages%2F1671601886474?alt=media&token=4d4249cf-a965-444f-a912-6fd9be0e5aed",

            });
            context.Movies.Add(new Movie()
            {
                Name = "Spider Man",
                Category = "Action",
                YearOfRelease = 2018,
                AvailaibilityStarts = new DateTime(2018 - 12 - 11),
                Description = "Spider-Man is a superhero appearing in American comic books published by Marvel Comics. Created by writer-editor Stan Lee and artist Steve Ditko, he first appeared in the anthology comic book Amazing Fantasy #15 (August 1962) in the Silver Age of Comic Books",
                IsFeatured = true,
                ContentPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fmovies%2F1671602062055?alt=media&token=bd67d0c6-48d6-4fd5-b6ff-8ef8f7aaf003",
                Views = 1,
                PosterPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fimages%2F1671602060229?alt=media&token=76ea84d0-dcdc-4bf8-8b6b-0b76d2f7d549",

            });
            context.Movies.Add(new Movie()
            {
                Name = "Journey 2",
                Category = "Action",
                YearOfRelease = 2015,
                AvailaibilityStarts = new DateTime(2016 - 05 - 12 ),
                Description = "This kind of movie is all about the special effects. They start out great - cool helicopter crash, very convincing giant lizard - but grow more amateurish as the film goes along, with a flight sequence on giant bees proving particularly clunky",
                IsFeatured = true,
                ContentPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fmovies%2F1671602207806?alt=media&token=50b772a8-c940-4f4b-8b2b-805bdfae6405",
                Views = 1,
                PosterPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fimages%2F1671602206103?alt=media&token=28a178db-e68f-4959-83e9-cdc104dfcdb8",

            });
            context.Movies.Add(new Movie()
            {
                Name = "RRR",
                Category = "Action",
                YearOfRelease = 2022,
                AvailaibilityStarts = new DateTime(2023 - 01 - 12),
                Description = "I've never seen anything like it — until now. A few nights ago, I went to a packed screening of RRR, an epic action-picture bromance from India. The screening had 900 people — some of whom had already seen the film 10 times — clapping and dancing from the opening credits.",
                IsFeatured = true,
                ContentPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fmovies%2F1671602369315?alt=media&token=a4fc3bf5-5e8a-422c-bb25-d613f4235d8b",
                Views = 1,
                PosterPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fimages%2F1671602365577?alt=media&token=ffbcfaf5-c817-42c8-ac92-c512b4d54b8f",

            });
            context.Movies.Add(new Movie()
            {
                Name = "Avatar 2",
                Category = "Sci Fi",
                YearOfRelease = 2022,
                AvailaibilityStarts = new DateTime(2022 - 11 - 22 ),
                Description = "The inevitable biggest blockbuster of 2022 arrives this weekend courtesy of writer-director James Cameron, with no serious doubt Disney-Fox’s Avatar: The Way of Water will score one of the biggest (if not the biggest) opening weekends of all time and earn front-runner status in the race for highest grossing film in cinema history. ",
                IsFeatured = true,
                ContentPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fmovies%2F1671602536230?alt=media&token=6d82b248-e573-4c86-aaf0-4320c7654cfe",
                Views = 1,
                PosterPath = "https://firebasestorage.googleapis.com/v0/b/netchill-ott.appspot.com/o/NetChill%2Fimages%2F1671602534819?alt=media&token=a6db06e8-0ac9-4f58-93c5-740074aa7ec9",

            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
