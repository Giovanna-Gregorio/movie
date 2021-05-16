using System.ComponentModel.DataAnnotations;

namespace movie2.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3), Required, Display(Name = "Nome")]
        public string Name { get; set; }

        public int IdMovie { get; set; }
        public Movie Movie { get; set; }
    }
}