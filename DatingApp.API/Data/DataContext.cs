using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    //la clase DataContext hereda a la clase DbContext del frameWork Entity
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        //informar a Entities sobre nuestras entidades 
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}