namespace BookService.Infrastructure.Migrations
{
    using BookService.Infrastructure.DBModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Infrastructure.DBBookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookService.Infrastructure.DBBookServiceContext context)
        {
            context.DBAuthors.AddOrUpdate(x => x.Id,
                new DBAuthor() { Id = 1, Name = "Jane Austen" },
                new DBAuthor() { Id = 2, Name = "Charles Dickens" },
                new DBAuthor() { Id = 3, Name = "Miguel de Cervantes" }
                );

            context.DBBooks.AddOrUpdate(x => x.Id,
                new DBBook()
                {
                    Id = 1,
                    Title = "Pride and Prejudice",
                    Year = 1813,
                    AuthorId = 1,
                    Price = 9.99M,
                    Genre = "Comedy of manners"
                },
                new DBBook()
                {
                    Id = 2,
                    Title = "Northanger Abbey",
                    Year = 1817,
                    AuthorId = 1,
                    Price = 12.95M,
                    Genre = "Gothic parody"
                },
                new DBBook()
                {
                    Id = 3,
                    Title = "David Copperfield",
                    Year = 1850,
                    AuthorId = 2,
                    Price = 15,
                    Genre = "Bildungsroman"
                },
                new DBBook()
                {
                    Id = 4,
                    Title = "Don Quixote",
                    Year = 1617,
                    AuthorId = 3,
                    Price = 8.95M,
                    Genre = "Picaresque"
                }
                );
        }
    }
}
