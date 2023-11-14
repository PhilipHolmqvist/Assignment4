using BJGameEL;
using Microsoft.EntityFrameworkCore;

namespace BJGameDAL
{

    /*
        DbContext (Database Context) is a class that represents a session with the
        database, and can be used read and update data, query and save instances of your
        entities into tables in the database.
     */
    public class DbConnection : DbContext
    {
        //It should be possible to add, change and delete an item in the database. 

        //Variablerna representerar tabeller i databasen.
        public DbSet<Player> Players {  get; set; }

      


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GameDb"); 
        }
    }
}