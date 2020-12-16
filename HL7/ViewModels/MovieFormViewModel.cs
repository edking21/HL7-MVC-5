using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HL7MVC5.Models;

namespace HL7MVC5.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(0, 20)]
        [Required]
        public byte? NumberInStock { get; set; }

        [Display(Name = "Number Available")]
        [Range(0, 20)]
        [Required]
        public byte? NumberAvailable { get; set; }


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
            NumberAvailable = movie.NumberAvailable;
            GenreId = movie.GenreId;
        }
    }
}