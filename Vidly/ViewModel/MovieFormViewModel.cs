using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModel
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        
        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public int? NumberInStock { get; set; } = 0;

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }
        public List<Genre> Genres { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
                
            }
             
        }
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}