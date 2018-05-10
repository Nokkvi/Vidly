namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValuesToMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES (Name, ReleaseDate, DateAdded, InStock, GenreId) VALUES ('Hangover', '2009-06-05', SYSDATETIME(), 10, 1)");
            Sql("INSERT INTO MOVIES (Name, ReleaseDate, DateAdded, InStock, GenreId) VALUES ('Die Hard', '1988-07-20', SYSDATETIME(), 12, 2)");
            Sql("INSERT INTO MOVIES (Name, ReleaseDate, DateAdded, InStock, GenreId) VALUES ('The Terminator', '1984-10-26', SYSDATETIME(), 22, 2)");
            Sql("INSERT INTO MOVIES (Name, ReleaseDate, DateAdded, InStock, GenreId) VALUES ('Toy Story', '1995-11-22', SYSDATETIME(), 8, 3)");
            Sql("INSERT INTO MOVIES (Name, ReleaseDate, DateAdded, InStock, GenreId) VALUES ('Titanic', '1997-12-19', SYSDATETIME(), 16, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
