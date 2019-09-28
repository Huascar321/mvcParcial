using System.Data.Entity;

namespace Huascar.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Huascar .Models.Fairy> Fairies { get; set; }
    }
}