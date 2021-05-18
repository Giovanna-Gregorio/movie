using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movie2.Models
{
    public class Movie
    {
        public int Id { get; set; }


        [StringLength(60, MinimumLength = 3), Required, Display(Name = "Título")]
        public string Title { get; set; }
        
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Lançamento"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required, StringLength(30), Display(Name = "Gênero")]
        public string Genre { get; set; }
        
        [Display(Name = "Preço"), Range(1, 100), DataType(DataType.Currency), Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]"), StringLength(4), Required]
        public string Rating { get; set; }

        public ICollection<Actor> Actors { get; set;}
        
    }
}