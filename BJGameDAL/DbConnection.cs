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
        DbSet<Player> Players {  get; set; }
    }
}