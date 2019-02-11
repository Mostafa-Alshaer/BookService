namespace BookService.Infrastructure
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBBookServiceContext : DbContext
    {
        // Your context has been configured to use a 'DBBookServiceContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BookService.Infrastructure.DBBookServiceContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBBookServiceContext' 
        // connection string in the application configuration file.
        public DBBookServiceContext()
            : base("name=DBBookServiceContext")
        {
        }

        public System.Data.Entity.DbSet<BookService.Infrastructure.DBModels.DBAuthor> DBAuthors { get; set; }

        public  System.Data.Entity.DbSet<BookService.Infrastructure.DBModels.DBBook> DBBooks { get; set; }
    }
}