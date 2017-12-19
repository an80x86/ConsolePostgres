using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePostgres
{
    [Table("film", Schema="public")]
    public class Film
    {
        [Column("film_id")]
        [Key]
        public int ID { get; set; }

        [Column("title")]
        public string Title { get; set; }
    }

    public class DB : DbContext
    {
        public DB() : base("dvds") { }
        public DbSet<Film> Films { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var db = new DB();
            foreach(var film in db.Films)
            {
                Console.WriteLine(film.Title);
            }
            Console.ReadKey();
        }
    }
}
